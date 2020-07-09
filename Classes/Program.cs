using Pleres.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pleres
{
    public static class WindowSettings
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
    static class Program
    {
        public static string loggedInUser = "Noone";
        public static MainForm mainFrm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //this.Hide();

            Login logon = new Login();

            ///if (logon.ShowDialog() == DialogResult.OK)
            {
               /// mainFrm = logon.releaseUsername();
                Application.Run(new MainForm("Sheamy"));
                ///logon.Close();
            }
            ///else
            {
                
                //Handle authentication failures as necessary, for example:
                ///Application.Exit();
            }
            


        }
    }
}
