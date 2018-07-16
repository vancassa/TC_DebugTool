using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motion_GUI
{
    public partial class frmEnable : Form
    {

        public frmEnable(bool enable, bool enableFw, bool enableBw)
        {
            InitializeComponent();
            cbController.Checked = enable;
            cbFwd.Checked = enableFw;
            cbBwd.Checked = enableBw;
            this.CenterToParent();
            this.TopMost = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            cbController.Checked = true;
            cbFwd.Checked = true;
            cbBwd.Checked = true;
            Panel_Axes.enable = true;
            Panel_Axes.enableFw = true;
            Panel_Axes.enableBw = true;
            Panel_Axes.lrOverride = 100;
            this.Close();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Panel_Axes.enable = cbController.Checked;
            Panel_Axes.enableFw= cbFwd.Checked;
            Panel_Axes.enableBw = cbBwd.Checked;
            Panel_Axes.lrOverride = uint.Parse(tbOverride.Text);
            this.Close();
        }
    }
}
