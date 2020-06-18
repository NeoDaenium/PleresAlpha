using Pleres.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace Pleres.Forms
{


    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private int tries;
        private List<UserModel> Usernames = new List<UserModel>();
        private SqliteDataAccess dataAccess = new SqliteDataAccess();
        public Login()
        {
            InitializeComponent();
            tries = 0;
        }



        private void validate()
        {   //Check if Empty
            if(txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                lblValidation.Visible = true;
                lblValidation.Text = "Please do not leave any fields blank.";
            }
            else//If not empty
            {
                if(dataAccess.ValidateUser(txtUsername.Text, txtPassword.Text))
                {
                    lblValidation.Visible = true;
                    lblValidation.Text = "You're the developer you cool cat you!";
                    MainForm mainfrm = new MainForm();
                    mainfrm.ShowDialog();
                    this.Close();
                }
                else
                {
                    tries++;
                    if (tries>=3)
                        System.Environment.Exit(0);

                    lblValidation.Visible = true;
                }
            }
                
        }

        public void loadUsers()
        {

            Usernames = SqliteDataAccess.GetUsers();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
