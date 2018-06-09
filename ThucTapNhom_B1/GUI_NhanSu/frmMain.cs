using GUI_NhanSu;
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

        private void tsLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void tsNVDA_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNV_DA nv_da = new frmNV_DA();
            nv_da.Show();
        }

        private void tsDeAn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDeAn dean = new frmDeAn();
            dean.Show();
        }

        private void tsNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNhanVien frmnv = new frmNhanVien();
            frmnv.Show();
        }
    }
}
