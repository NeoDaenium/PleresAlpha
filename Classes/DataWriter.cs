using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ClosedXML.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Pleres.Classes
{
    public class DataWriter
    {
        StringBuilder contentToWrite;
        private string path = @"C:\Users\Janda\AppData\Local\Pleres\Data\Products\";
        private string fileName = "Inventory.xlsx";
        string[] spindle = new string[15] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M","N","O" };
        private int armature = 0;
        private bool isInDebugMode = true;//SET TO FALSE WHEN RELEASED IN BETA

        public string Path { get => path; set => path = value; }
        public int Armature { get => armature; set => armature = value; }
        public string FileName { get => fileName; set => fileName = value; }

        public DataWriter()
        {
            contentToWrite = new StringBuilder();
        }
        public void writeDataToSheet(Product _product)
        {//Accept one item only
            //contentToWrite.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6}",_product.Category ,_product.GenericName , _product.FdaRegistrationNumber , _product.LotNumber ,_product.BasePrice ,_product.SellingPrice , _product.DistrictNumber.ToString() , _product.CostPrice));
            //File.AppendAllText(path + "products.xslx", contentToWrite.ToString());
            
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Products");
                Armature = 1; int counter = 0;
                worksheet.Cell(spindle[counter++] + Armature.ToString()).Value = _product.Category;
                worksheet.Cell(spindle[counter++] + Armature.ToString()).Value = _product.GenericName;
                worksheet.Cell(spindle[counter++] + Armature.ToString()).Value = _product.FdaRegistrationNumber;
                worksheet.Cell(spindle[counter++] + Armature.ToString()).Value = _product.LotNumber;
                worksheet.Cell(spindle[counter++] + Armature.ToString()).Value = _product.BasePrice;
                worksheet.Cell(spindle[counter++] + Armature.ToString()).Value = _product.SellingPrice;
                worksheet.Cell(spindle[counter++] + Armature.ToString()).Value = _product.DistrictNumber.ToString();
                worksheet.Cell(spindle[counter++] + Armature.ToString()).Value = _product.CostPrice;

                workbook.SaveAs(Path+FileName);
                logOnDebug("Saved file as: "+ Path + FileName);
            }
            clearCache();
        }
        public ArrayList readDataFromSheet()//Reads data and builds objects
        {
            Excel.Application excelAppInstance = new Excel.Application();
            Excel.Workbook excelWorkbook = excelAppInstance.Workbooks.Open(Path + FileName);
            Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            Excel.Range dataTable = excelWorksheet.UsedRange;
            Queue readData = new Queue();
            ArrayList productList = new ArrayList();

            int rowCount = dataTable.Rows.Count;
            int colCount = dataTable.Columns.Count;
            
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //Every New Line
                    if (j == 1)
                    {
                        armature++;
                    }
                    //Write the value to the console
                    if (dataTable.Cells[i, j] != null && dataTable.Cells[i, j].Value2 != null)
                    {
                        string tempData = dataTable.Cells[i, j].Value2.ToString();
                        readData.Enqueue(tempData);
                    }
                    else
                    {
                        readData.Enqueue(null);//[ACCEPTS NULL WARNING!]Data reader accepts null as is
                        logOnDebug("Warning, NULL value detected in: " + path + fileName + "Line Number: " + armature.ToString());
                    }
                    if(j == colCount)
                    {
                        Product product = new Product(Int32.Parse(readData.Dequeue().ToString()), readData.Dequeue().ToString(), readData.Dequeue().ToString(), readData.Dequeue().ToString(), readData.Dequeue().ToString(), readData.Dequeue().ToString(), decimal.Parse(readData.Dequeue().ToString()), decimal.Parse(readData.Dequeue().ToString()), Int32.Parse(readData.Dequeue().ToString()));
                        logOnDebug(product.ToString());
                        productList.Add(product);
                    }
                }
            }
            //Try to cleanup
            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.ReleaseComObject(dataTable);
                Marshal.ReleaseComObject(excelWorksheet);
                excelWorkbook.Close();
                Marshal.ReleaseComObject(excelWorkbook);
                //Release objects App instance
                excelAppInstance.Quit();
                Marshal.ReleaseComObject(excelAppInstance);
            }
            catch (Exception ex)//[EX0001]
            {
                logOnDebug("Exception triggered, EX0001 - Unable to clean up resources.");
            }
            foreach (String str in readData){
                logOnDebug(str);
            }
            return productList;
        }
        public void writeDataToCSV(ArrayList _products)
        {//Accept an arraylist of items
            foreach(Product _product in _products)
            {
                contentToWrite.AppendLine("\"" + _product.Id.ToString() + "," + _product.Category + "," + _product.GenericName + "," + _product.FdaRegistrationNumber + "," + _product.LotNumber + "," + _product.BasePrice + "," + _product.SellingPrice + "," + _product.DistrictNumber.ToString() + "," + _product.CostPrice + "\"");
            }
            File.AppendAllText(Path + "products.csv", contentToWrite.ToString());
            clearCache();
        }
        private void clearCache()
        {
            contentToWrite.Clear();
        }
        public void logOnDebug(String _message)
        {
            if (isInDebugMode)
                Debug.Write(_message);
        }
    }
}
