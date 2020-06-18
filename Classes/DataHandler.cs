using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pleres.Classes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace Pleres
{
    public class DataHandler
    {
        /*
         TO DOs
         DO Data Validation - No Id Duplications , product ID, FDA, Lot 
         Search and edit function update registers
         Create Duplication search handler
         Create Quicksort to sort all items
         CRUD
         Interface To Data Writer
         GUI - UX | Dark Gray | Fuschia | 

        */


        private string dataFolder;
        private string fileTarget;
        private bool isInDebugMode = true;
        public DataHandler()
        {
            dataFolder = @"C:\Users\Janda\AppData\Local\Pleres\Data\";
            fileTarget = "File.txt";
        }
        public bool setTarget(String _dataFolder,String _fileTarget)
        {
            bool fileExists = fileCheck(_dataFolder + _fileTarget);
            if (fileExists)
            {
                dataFolder = _dataFolder;
                fileTarget = _fileTarget;
                return true;
            }
            else
            {
                try
                {
                    File.Create(_dataFolder + _fileTarget);
                    return true;
                }
                catch(Exception exception)
                {
                    return false;
                }
            }
        }
        public bool appendToFile(String _textToWrite,String _fileName)
        {   ///Creates a new file if file does not exist
            try
            {
                StreamWriter sw = new StreamWriter(dataFolder + fileTarget, true);
                sw.WriteLine(_textToWrite);
                logOnDebug("Successfully Wrote: " + _textToWrite);//#DEBUG
                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false;
            }
        }
        public bool writeToFile(String _textToWrite, String _fileName)
        {   ///Returns false if file does not exist
            try
            {
                StreamWriter sw = new StreamWriter(dataFolder + fileTarget);
                sw.WriteLine(_textToWrite);
                Console.WriteLine("Successfully Wrote: " + _textToWrite);//#DEBUG
                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                logOnDebug("Exception: " + e.Message);
                return false;
            }
        }
        public static void addRecord(string _id,string _name,string _data)
        {

        }
        public ArrayList grabData()
        {
            if(fileCheck(dataFolder + fileTarget)) {
                ArrayList data = new ArrayList(File.ReadAllLines(dataFolder + fileTarget).ToList());
                logOnDebug("Data File is available.");//#DEBUG
                return data;
            }
            else
            {
                logOnDebug("Data File is unavailable.");//#DEBUG
                return new ArrayList();
            }
        }
        public void serializeObject(Product _product)
        {
            try
            {
                using (Stream stream = File.Open(dataFolder+@"Products\"+_product.Id + ".prod", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream,_product);
                    stream.Close();
                }
            }
            catch (IOException)
            {
                logOnDebug("Data File is unavailable. We were not able to serialize your data.");//#DEBUG
            }
        }
        public Product deserializeObject(String _pathToFile)
        {
            Product product;
            try
            {
                using (Stream stream = File.Open(_pathToFile, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    product = (Product)(bin.Deserialize(stream));
                    stream.Close();
                }
                return product;
            }
            catch (IOException)
            {
                logOnDebug("Product file is unavailable. We were not able to deserialize your data.");//#DEBUG
            }
            return new Product();
        }
        public ArrayList grabAllProducts()
        {
            ArrayList _products = new ArrayList();
            try
            {
                foreach (string f in Directory.GetFiles(dataFolder + @"Products\"))
                {
                    _products.Add(deserializeObject(f));
                }
                return _products;
            }
            catch (System.Exception excpt)
            {
                logOnDebug(excpt.Message);
            }
            return new ArrayList();
        }
        public void writeHashTable(Hashtable _hashTable)
        {///Write the contents of a Hashtable both keys and values
            try
            {
                StreamWriter sw = new StreamWriter(dataFolder + fileTarget);
                foreach (DictionaryEntry item in _hashTable)
                {
                  sw.WriteLine("{0} {1}", item.Key, item.Value);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                logOnDebug("Exception: " + ex.Message);
                return;
            }
        }
        public bool fileCheck(String _filePath)
        {   ///Shorthand if else to check if a file exists
            bool returnValue = File.Exists(_filePath) ? true : false;
            return returnValue;
        }
        public void logOnDebug(String _message)
        {
            if (isInDebugMode)
                Debug.Write(_message);
        }
    }
}
