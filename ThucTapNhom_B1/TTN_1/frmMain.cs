using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_1.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ttPhongBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPhongBan fpb = new frmPhongBan();
            fpb.Show();
        }
    }
}
