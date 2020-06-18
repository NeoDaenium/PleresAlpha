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
    public partial class ProductEditor : Form
    {
        private static String dataFolder = @"C:\Users\Janda\AppData\Local\Pleres\Data\";
        private static String dataFile = "Products.dat";
        private DataHandler dataControl = new DataHandler();
        public ProductEditor()
        {
            dataControl.setTarget(dataFolder, dataFile);
            dataControl.grabAllProducts();
            InitializeComponent();
            ArrayList productList = dataControl.grabAllProducts();

            dgvMain.DataSource = productList;
        }
    }
}
