using System;
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
    public partial class Clients : Form
    {
        private bool topGroupHidden = false;
        private bool midGroupHidden = false;
        private bool btmGroupHidden = false;
        public Clients()
        {
            InitializeComponent();
            //btnMinimizeGroup1.ToolTip
        }

        private void btnMinimizeGroup1_Click(object sender, EventArgs e)
        {
            topGroupHidden = ToggleValue(topGroupHidden);
            UpdateValues();
        }

        private bool ToggleValue(bool _value)
        {
            if (_value)
                return false;
            else
                return true;
        }
        private void UpdateValues()
        {
            gbxTop.Visible = topGroupHidden;
            gbxMid.Visible = midGroupHidden;
            gbxBtm.Visible = btmGroupHidden;
        }

        private void btnMinimizeGroup2_Click(object sender, EventArgs e)
        {
            midGroupHidden = ToggleValue(midGroupHidden);
            UpdateValues();
        }

        private void btnMinimizeGroup3_Click(object sender, EventArgs e)
        {
            btmGroupHidden = ToggleValue(btmGroupHidden);
            UpdateValues();
        }
    }
}
