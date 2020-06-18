using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pleres.Classes;
using Pleres.Forms;

namespace Pleres
{
    public partial class MainForm : Form
    {
        private ArrayList productPool = new ArrayList();
        private static String dataFolder = @"C:\Users\Janda\AppData\Local\Pleres\Data\";
        private static String dataFile = "Data.dat";
        private int buttonWidth = 230;
        private int buttonHeight;
        private bool isTicking = false;
        private bool hideUI = false;

        
        public MainForm()
        {
            InitializeComponent();
        }
        private void PleresMain_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(29, 29, 29);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void MnuAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct newMDIChild = new AddProduct { BackgroundImage = new Bitmap(@"C:\Users\Janda\Downloads\Aqua.png"), };
            newMDIChild.MdiParent = this;

                newMDIChild.Show();
        }
        private void MnuEditProducts_Click(object sender, EventArgs e)
        {
            ProductEditor newMDIChild = new ProductEditor();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void MnuAddBatch_Click(object sender, EventArgs e)
        {
            //Bat newMDIChild = new ProductEditor();
            //newMDIChild.MdiParent = this;
            //newMDIChild.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if(lbl.BackColor != System.Drawing.Color.Red) { 
            lbl.BackColor = System.Drawing.Color.Red;
                this.IsMdiContainer = true;
            }
            else
            {
                lbl.BackColor = System.Drawing.Color.Transparent;
                this.IsMdiContainer = false;
            }
            
        }
        #region Technical
        private void valueChanged(object sender, EventArgs e)
        {
  
            var clickedBox = (RadioButton)sender;
            if(clickedBox.GetType().ToString() == "System.Windows.Forms.RadioButton")
            {
                if (clickedBox.Checked)
                {
                    clickedBox.Image = Image.FromFile(@"C:\Users\Janda\source\repos\Pleres\Resources\ImgUI\Icons\radiodisabled.png");
                }
                else
                {
                    clickedBox.Image = Image.FromFile(@"C:\Users\Janda\source\repos\Pleres\Resources\ImgUI\Icons\radiolite.png");
                }
            }
        }
        private void checkedCheck(object sender, EventArgs e)
        {
            var clickedBox = (CheckBox)sender;
            if (clickedBox.GetType().ToString() == "System.Windows.Forms.CheckBox")
            {
                //MessageBox.Show("asd", clickedBox.GetType().ToString());
                if (clickedBox.Checked)
                {

                    clickedBox.Image = Image.FromFile(@"C:\Users\Janda\source\repos\Pleres\Resources\ImgUI\Icons\boxdisabled.png");
                }
                else
                {
                    clickedBox.Image = Image.FromFile(@"C:\Users\Janda\source\repos\Pleres\Resources\ImgUI\Icons\boxlite_checked.png");
                }
            }
        }
        private void Button_ExpandEffect(object sender, EventArgs e)
        {
            var hoverBox = (Button)sender;
            hoverBox.Text = "   " + hoverBox.Text;
            //hoverBox.Location = new Point(hoverBox.Location.X+2, hoverBox.Location.Y);
            hoverBox.Size = new Size(hoverBox.MaximumSize.Width, hoverBox.MaximumSize.Height);
        }
        private void Button_Contract(object sender, EventArgs e)
        {
            isTicking = false;
            var exitBox = (Button)sender;
            exitBox.Text = exitBox.Text.Replace(" ", "");
            exitBox.Size = new Size(exitBox.MinimumSize.Width, exitBox.MinimumSize.Height);
        }
        private void Group_ExpandEffect(object sender, EventArgs e)
        {
            var hoverBox = (Panel)sender;
            hoverBox.Text = "   " + hoverBox.Text;
            //hoverBox.Location = new Point(hoverBox.Location.X+2, hoverBox.Location.Y);
            hoverBox.Size = new Size(hoverBox.MaximumSize.Width, hoverBox.MaximumSize.Height);
        }
        private void Group_Contract(object sender, EventArgs e)
        {
            isTicking = false;
            var exitBox = (Panel)sender;
            exitBox.Text = exitBox.Text.Replace(" ", "");
            exitBox.Size = new Size(exitBox.MinimumSize.Width, exitBox.MinimumSize.Height);
        }


        private bool toggle(bool _value)
        {
            if (_value) return false;
            else return true;
        }
        private void TmrCurrent_Tick(object sender, EventArgs e)
        {
            this.indTime.Text = DateTime.Now.ToString("hh:mm tt");
            this.indDate.Text = DateTime.Now.ToString("dddd, MMM dd, yyyy");

        }
#endregion

        private void BtnHideAll_Click(object sender, EventArgs e)
        {
            hideUI = toggle(hideUI);
            if (hideUI) HideUI();
            else ShowUI();

        }

        private void HideUI()
        {
            tblLayoutCenter.Visible = false;
            Opacity = 10;
            mnuMain.Visible = false;
            pnlTop.Visible = false;
            pnlNotifications.Visible = false;
            pnlUser.Visible = false;
            pnlContacts.Visible = false;
            pnlInventory.Visible = false;
            pnlTerminal.Visible = false;
            pnlReports.Visible = false;
            pnlSideBar.Visible = false;
            pnlDocuments.Visible = false;
            pnlOperations.Visible = false;
            tblLayoutCenter.Visible = true;
            
            Opacity = 100;
        }
        private void ShowUI()
        {
            
            Opacity = 50;
            mnuMain.Visible = true;
            pnlTop.Visible = true;
            pnlNotifications.Visible = true;
            pnlUser.Visible = true;
            pnlContacts.Visible = true;
            pnlInventory.Visible = true;
            pnlTerminal.Visible = true;
            pnlReports.Visible = true;
            pnlSideBar.Visible = true;
            pnlDocuments.Visible = true;
            pnlOperations.Visible = true;

            Opacity = 100;
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            pnlSideBar.Visible = false;
        }
    }
}
