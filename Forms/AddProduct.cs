using Pleres.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pleres.Forms
{
    public partial class AddProduct : Form
    {
        private static String dataFolder = @"C:\Users\Janda\AppData\Local\Pleres\Data\";
        private static String dataFile = "Products.dat";
        private ArrayList productsData = new ArrayList();
        private static DataHandler dataControl = new DataHandler();
        private static DataWriter dataWriter = new DataWriter();
        private int idCounter;
        
        public AddProduct()
        {
            InitializeComponent();
            dataControl.setTarget(dataFolder,dataFile);
            idCounter = 0;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {//(int _id,String _category,String _brandName, String _genericName, String _fdaRegistrationNumber, String _lotNumber, Decimal _price, Decimal _cost
            dataWriter.readDataFromSheet();

            idCounter++;
            Product newProduct = new Product
            (idCounter,
            cmbProductCategory.Text,
            txtBrandName.Text,
            txtGenericName.Text,
            txtFDARegistrationNumber.Text,
            txtLotNumber.Text,
            decimal.Parse(txtPrice.Text),
            decimal.Parse(txtCost.Text),
            Int32.Parse(cmbDistrict.Text));

            dataWriter.writeDataToSheet(newProduct);

            //dataControl.serializeObject(newProduct);
        }
    }
}
