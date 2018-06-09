using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom_Bai1.View;
using ThucTapNhom_Bai1.BUS;
using ThucTapNhom_Bai1.DAO;

namespace ThucTapNhom_Bai1
{
    public partial class frmNhanSu : Form
    {
        
        public frmNhanSu()
        {
            InitializeComponent();
            //LoadDataNhanVien();
            LoadDataPhongBan();
            //LoadDataDeAn();
        }
        int op;
        void ClearData()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtMaQL.Text = "";
            txtDiaDiem.ResetText();
        }
        BUS_PhongBan busPhongBan = new BUS_PhongBan();
        void LoadDataNhanVien()
        {
            //dtgrvNhanVien.DataSource = cq.ShowDatainGridView("Select manv, ten, ngaysinh,gioitinh,luong,diachi,tenphong from Nhanvien,Phongban where phongban.maphong = nhanvien.maphong ");
            //foreach (DataGridViewRow p in dtgrvNhanVien.Rows)
            //{
            //    if (String.Compare(p.Cells[4].Value.ToString(), "1") == 0)
            //    {
            //        p.Cells[4].Value = "Nam";
            //    }
            //    if (String.Compare(p.Cells[4].Value.ToString(), "0") == 0)
            //    {
            //        p.Cells[4].Value = "Nữ";
            //    }
            //    else
            //        p.Cells[4].Value = "Khác";
            //}
        }
        void LoadDataPhongBan()
        {
            dtgvPhongBan.DataSource = busPhongBan.GetData();
        }
        void LoadDataDeAn()
        {
          //  dtgrDeAn.DataSource = cq.ShowDatainGridView("select * from DeAn");
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fm = new frmMain();
            fm.Show();
        }

        private void dtgrvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaNV.Text =
               (dtgrvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString());
                txtHoTen.Text =
               Convert.ToString(dtgrvNhanVien.CurrentRow.Cells["Ten"].Value.ToString());
                txtLuong.Text =
               (dtgrvNhanVien.CurrentRow.Cells["luong"].Value.ToString());
                txtDiaChi.Text =
               (dtgrvNhanVien.CurrentRow.Cells["diachi"].Value.ToString());
                cmPhongBan.Text =
                (dtgrvNhanVien.CurrentRow.Cells["tenphong"].Value.ToString());
                if (dtgrvNhanVien.CurrentRow.Cells["gioitinh"].Value.ToString() == "1")
                {
                    rdNam.Checked = true;
                }
                else if (dtgrvNhanVien.CurrentRow.Cells["gioitinh"].Value.ToString() == "0")
                {
                    rdNu.Checked = true;
                }
                else 
                rdKhac.Checked = true;
                dtNV.Text = dtgrvNhanVien.CurrentRow.Cells["ngaysinh"].Value.ToString();
                //Show_CboPhongBan(DgrNhanvien.CurrentRow.Cells["MaPB"].Value.ToString());
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (txtMaNV.Text != "" && txtLuong.Text != "" && txtHoTen.Text != "" && txtDiaChi.Text != "" )
                {

                    try
                    {
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Bạn cần điền đầy đủ thông tin Nhân viên");
            }

        }

        private void cmPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmPhongBan.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmMain fm = new frmMain();
            //fm.Show();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMain fm = new frmMain();
            fm.Show();
        }

        private void dtgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dtgvPhongBan.CurrentRow.Cells["MaPhong"].Value.ToString().Trim();
            txtTenPhong.Text = dtgvPhongBan.CurrentRow.Cells["TenPhongban"].Value.ToString().Trim();
            txtMaQL.Text = dtgvPhongBan.CurrentRow.Cells["manql"].Value.ToString().Trim();
            txtDiaDiem.Text = dtgvPhongBan.CurrentRow.Cells["DiaDiem"].Value.ToString().Trim();
        }
        void HideButton(bool b)
        {
            btThemPhongBan.Enabled = b;
            btSua.Enabled = b;
            btXoa.Enabled = b;
            btTimKiem.Enabled = b;
        }
        private void btThemPhongBan_Click(object sender, EventArgs e)
        {
            op = 1; //Chon them phong ban
            ClearData();
            HideButton(false);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                PhongBan pb = new PhongBan(txtMaPhong.Text, txtTenPhong.Text, txtMaQL.Text, txtDiaDiem.Text);
                if (busPhongBan.Sua(pb))
                {
                    MessageBox.Show("Sửa thành công");
                    dtgvPhongBan.DataSource = busPhongBan.GetData();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra");
            }
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (busPhongBan.Xoa(txtMaPhong.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    dtgvPhongBan.DataSource = busPhongBan.GetData();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra");
              
            }   
        }
        Connection_Query cq = new Connection_Query();
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                if (txtMaPhong.Text != "" && txtTenPhong.Text != "" && txtMaQL.Text != "" && txtDiaDiem.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        PhongBan pb = new PhongBan(txtMaPhong.Text.Trim(), txtTenPhong.Text.Trim(), txtMaQL.Text.Trim(), txtDiaDiem.Text.Trim());
                        try
                        {
                            cq.ExecuteQueries("INSERT INTO dbo.PhongBan ( MaPhong, TenPhong, MaNQL, DiaDiem )VALUES  ('" + txtMaPhong.Text + "',N'" + txtTenPhong.Text + "',N'" + txtMaQL.Text + "',N'" + txtDiaDiem.Text + "')");
                            cq.OpenConnection();
                            dtgvPhongBan.DataSource = cq.ShowDatainGridView("select * from phongban");
                            cq.CloseConnection();
                            MessageBox.Show("Ok man");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        //if (busPhongBan.Them(pb) == true)
                        //{
                        //    MessageBox.Show("Thêm thành công !");
                        //    //dtgvPhongBan.DataSource = busPhongBan.GetData();
                        //}
                        //else
                        //    MessageBox.Show("Đã có lỗi xảy ra !");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần điền đầy đủ thông tin ");
                    txtMaPhong.Focus();
                }
            }
            if (op == 0)
            {

            }
        }
    }
}
