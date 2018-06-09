using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_Bai1.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (frmLogin.quyen == 1)
            {
                lbUser.Text = frmLogin.lbUser + "  : Admin";
            }
            else if (frmLogin.quyen == 2)
            {
                lbUser.Text = frmLogin.lbUser + "   : Update tác vụ";
            }
            else
                lbUser.Text = frmLogin.lbUser + "   : Read-Only";
            ////tcNhanSu.TabPages.Remove(tpNhanVien);
            ////tcNhanSu.TabPages.Remove(tpDuAn);
            ////tcNhanSu.TabPages.Remove(tpPhongBan);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tsLogOut_Click(object sender, EventArgs e)
        {
           // DialogResult dr =MessageBox.Show("Bạn có muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            this.Close();
        }
        private void tsNhanVien(object sender, EventArgs e)
        {
           

        }

        private void pHÒNGBANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tcNhanSu.TabPages.Add(tpPhongBan);
        }

        private void tsNhanSu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNhanSu fNhanSu = new frmNhanSu();
            fNhanSu.Show();
        }
    }
}
