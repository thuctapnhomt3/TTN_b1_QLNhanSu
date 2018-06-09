using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_1.GUI;

namespace GUI_NhanSu
{
    public partial class frmNV_DA : Form
    {
        public frmNV_DA()
        {
            InitializeComponent();
            ShowData();
            LoadData();
            if (frmLogin.quyen == 1)
            {
                PhanQuyen(true);
            }
            else
                PhanQuyen(false);
            txtMaNV.Text = cbTenNV.SelectedValue.ToString();
            txtMaDA.Text = cbTenDA.SelectedValue.ToString();
        }
        void PhanQuyen(bool b)
        {
            btThem.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
        }
        BUSNV_DA bus_nvda = new BUSNV_DA();
        void ShowData()
        {
            dtgvNVDA.DataSource = bus_nvda.GetData();
            EnabledData(false);
        }
        private void EnabledData(bool b)
        {
            txtMaDA.Enabled = b;
            txtMaNV.Enabled = b;
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
        void LoadData()
        {
            cbTenNV.DataSource = bus_nvda.GetDataComNV();
            cbTenNV.DisplayMember = "Ten";
            cbTenNV.ValueMember = "manv";
            cbTenDA.DataSource = bus_nvda.GetDataComDA();
            cbTenDA.DisplayMember = "TenDa";
            cbTenDA.ValueMember = "mada";
        }
        private void btThem_Click(object sender, EventArgs e)
        {

        }
        string type;
        private void btSua_Click(object sender, EventArgs e)
        {
            type = "Sua";
            EnabledData(true);
            EnableMethod(false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void dtgvNVDA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvNVDA.Rows[e.RowIndex];
                cbTenNV.Text = row.Cells[0].Value.ToString().Trim();
                txtMaNV.Text = row.Cells[1].Value.ToString().Trim();
                cbTenDA.Text = row.Cells[2].Value.ToString().Trim();
                txtMaDA.Text = row.Cells[3].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = bus_nvda.GetEx();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
            
        }

        private void btTiemKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                btHienThi.Enabled = true;
                if (bus_nvda.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dtgvNVDA.DataSource = bus_nvda.GetDataTimKiem(txtTimKiem.Text.Trim());
                    MessageBox.Show("Tìm thành công");
                }
                else
                {
                    Exception ex = bus_nvda.GetEx();
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

        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = cbTenNV.SelectedValue.ToString();
        }

        private void cbTenDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaDA.Text = cbTenDA.SelectedValue.ToString();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (type == "Sua")
            {
                if (cbTenDA.Text != "" && cbTenNV.Text != "")
                {
                    NVDA nvda = new NVDA(cbTenNV.SelectedValue.ToString().Trim(), cbTenDA.SelectedValue.ToString().Trim());
                    if (bus_nvda.Sua(nvda,txtMaDA.Text, txtMaNV.Text) == true)
                    {
                        ShowData();
                        EnableMethod(true);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        Exception ex = bus_nvda.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin Nhân viên - Đề án");
            }


        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            EnabledData(false);
            EnableMethod(true);
        }
    }
}
