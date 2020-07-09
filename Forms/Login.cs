using Pleres.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace Pleres.Forms
{
    public partial class Login : Form
    {
        public String loggedInUser = "Noone";
        public MainForm mainfrm;
        public int userID;
        private int tries;
        private List<UserModel> Usernames = new List<UserModel>();

        public Login()
        {
            InitializeComponent();
            tries = 0;
            
        }
        public MainForm releaseUsername()
        {
            return mainfrm;
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
                if(SqliteDataAccess.AuthenticateUser(txtUsername.Text, txtPassword.Text))
                {
                    lblValidation.Visible = true;
                    lblValidation.Text = "You're the developer you cool cat you!";
                    mainfrm = new MainForm(txtUsername.Text);
                    this.DialogResult = DialogResult.OK;
                    //this.Close();
                    //Application.Run(new MainForm(txtUsername.Text));

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
            Usernames = SqliteDataAccess.GetLoginData();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            validate();
            //txtUsername.Text = PleresSecurity.Season(txtPassword.Text);
            //btnLogin.Text = PleresSecurity.CompareHash(txtPassword.Text,PleresSecurity.WriteUid(),txtUsername.Text).ToString();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowSettings.ReleaseCapture();
                WindowSettings.SendMessage(Handle, WindowSettings.WM_NCLBUTTONDOWN, WindowSettings.HT_CAPTION, 0);
            }
        }
    }
}
