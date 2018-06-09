using BUS;
using DAO;
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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
            ShowData();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);

        }
        BUSPhongBan bus_pb = new BUSPhongBan();
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        private void EnabledData(bool b)
        {
            txtMaPhongBan.Enabled = b;
            txtTen.Enabled = b;
            txtMaQL.Enabled = b;
            TxtDiaDiem.Enabled = b;
            btOk.Visible = b;
            btCancel.Visible = b;
        }
        private void EnableMethod(bool b)
        {
            if (frmLogin.quyen == 1)
            {
                btThem.Enabled = b;
                btSua.Enabled = b;
                btXoa.Enabled = b;
            }
        }
        void FormatData()
        {
            txtMaPhongBan.Text = "";
            txtTen.Text = "";
            txtMaQL.Text = "";
            TxtDiaDiem.Text = "";
        }
        void ShowData()
        {
            dtgvPhongBan.DataSource = bus_pb.GetData();
            EnabledData(false);
        }
        string type;
        private void btThem_Click(object sender, EventArgs e)
        {
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            type = "Sua";
            EnabledData(true);
            EnableMethod(false);
            txtMaPhongBan.Enabled = false;
        }

        private void dtgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvPhongBan.Rows[e.RowIndex];
                txtMaPhongBan.Text = row.Cells[0].Value.ToString().Trim();
                txtTen.Text = row.Cells[1].Value.ToString().Trim();
                txtMaQL.Text = row.Cells[2].Value.ToString().Trim();
                TxtDiaDiem.Text = row.Cells[3].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = bus_pb.GetEx();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btTiemKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                btHienThi.Enabled = true;
                if (bus_pb.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    FormatData();
                    dtgvPhongBan.DataSource = bus_pb.GetDataTimKiem(txtTimKiem.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = bus_pb.GetEx();
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Lỗi rồi bạn ơi !");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            btHienThi.Enabled = false;
            txtTimKiem.Text = "";
            ShowData();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            EnabledData(false);
            EnableMethod(true);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
           
            if (type == "Sua")
            {
                if (txtMaPhongBan.Text != "" && txtTen.Text != "" && txtMaQL.Text != "" && TxtDiaDiem.Text != "")
                {
                    PhongBan pb = new PhongBan(txtMaPhongBan.Text.Trim().ToString(), txtTen.Text.Trim().ToString(), txtMaQL.Text.Trim().ToString(), TxtDiaDiem.Text.Trim().ToString());
                    if (bus_pb.Sua(pb) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        Exception ex = bus_pb.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
        }
    }
}
