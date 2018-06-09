using BUS;
using System;
using System.Windows.Forms;

namespace TTN_1.GUI
{
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
            ShowData();
        }
        BUSPhongBan bus_pb = new BUSPhongBan();
        void ShowData()
        {
            dtgvPhongBan.DataSource = bus_pb.GetData();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhongBan.Text != "" && txtTen.Text != "" && txtMaQL.Text != "" && TxtDiaDiem.Text != "")
            {
                PhongBan pb = new PhongBan(txtMaPhongBan.Text.Trim().ToString(), txtTen.Text.Trim().ToString(), txtMaQL.Text.Trim().ToString(), TxtDiaDiem.Text.Trim().ToString());
                if (bus_pb.Them(pb) == true)
                {
                    ShowData();
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Có lỗi xảy ra");
//                try
//                {
//                    string query = @"Insert INTO dbo.PhongBan( MaPhong ,TenPhongBan , MaNQL ,DiaDiem)
//                                VALUES  ( '" + pb.Ma + "',N'" + pb.Ten + "', '" + pb.MaQL + "',N'" + pb.DiaDiem + "')";
//                    cc.OpenConection();
//                    cc.ExecuteQueries(query);
//                    cc.CloseConnection();
//                    ShowData();
//                    MessageBox.Show("Thành công");
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show(ex.Message);
//                }
            }
            else
                MessageBox.Show("Bạn cần nhập đủ thông tin phòng ban");
        }
    }
}
