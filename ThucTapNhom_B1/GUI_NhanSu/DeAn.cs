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
    public partial class frmDeAn : Form
    {
        public frmDeAn()
        {
            InitializeComponent();
            ShowData();
            LoadCom();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);
            txtMaPhong.Text = cbTenPhong.SelectedValue.ToString();
        }
        private void ShowData()
        {
            dtgrDeAn.DataSource = bus_da.GetData();
            EnabledData(false);
        }
        void LoadCom()
        {
            cbTenPhong.DataSource = bus_da.GetDataCom();
            cbTenPhong.DisplayMember = "TenPhongBan";
            cbTenPhong.ValueMember = "maphong";
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        void FormatData()
        {
            txtMaDeAn.Text = "";
            txtSoGio.Text = "";
            txtTen.Text = "";
        }
        private void EnabledData(bool b)
        {
            txtMaDeAn.Enabled = b;
            txtTen.Enabled = b;
            txtSoGio.Enabled = b;
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
        BUSDeAn bus_da = new BUSDeAn();

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmmain = new frmMain();
            frmmain.Show();
        }
        string type;
        private void btThem_Click(object sender, EventArgs e)
        {
            type = "Them";
            EnabledData(true);
            EnableMethod(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            type = "Sua";
            EnabledData(true);
            EnableMethod(false);
            txtMaDeAn.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void dtgrDeAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgrDeAn.Rows[e.RowIndex];
                txtMaDeAn.Text = row.Cells[0].Value.ToString().Trim();
                txtTen.Text = row.Cells[1].Value.ToString().Trim();
                txtSoGio.Text = row.Cells[2].Value.ToString().Trim();
                txtMaPhong.Text = row.Cells[3].Value.ToString().Trim();
                cbTenPhong.Text = row.Cells[4].Value.ToString().Trim();
                
            }
            catch (Exception ex)
            {
                ex = bus_da.GetEx();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void btTiemKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                btHienThi.Enabled = true;
                if (bus_da.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    FormatData();
                    dtgrDeAn.DataSource = bus_da.GetDataTimKiem(txtTimKiem.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = bus_da.GetEx();
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

        private void cbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaPhong.Text = cbTenPhong.SelectedValue.ToString();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (type == "Them")
            {
                if (txtMaDeAn.Text != "" && txtTen.Text != "" && txtSoGio.Text != "" && cbTenPhong.Text != "")
                {
                    DeAn da = new DeAn(txtMaDeAn.Text.Trim().ToString(), txtTen.Text.Trim().ToString(), int.Parse(txtSoGio.Text), cbTenPhong.SelectedValue.ToString().Trim());
                    if (bus_da.Them(da) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = bus_da.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }
            if (type == "Sua")
            {
                if (txtMaDeAn.Text != "" && txtTen.Text != "" && txtSoGio.Text != "" && cbTenPhong.Text != "")
                {
                    DeAn da = new DeAn(txtMaDeAn.Text.Trim().ToString(), txtTen.Text.Trim().ToString(), int.Parse(txtSoGio.Text.ToString().Trim()), cbTenPhong.SelectedValue.ToString().Trim());
                    if (bus_da.Sua(da) == true)
                    {
                        FormatData();
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        Exception ex = bus_da.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            EnabledData(false);
            EnableMethod(true);
        }
    }
}
