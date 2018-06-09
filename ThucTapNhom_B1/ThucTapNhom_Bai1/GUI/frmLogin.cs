using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom_Bai1.View;
using System.Data.SqlClient;

namespace ThucTapNhom_Bai1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Connection_Query cq = new Connection_Query();
        static public string lbUser;
        public static int quyen;
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btChon_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ tên tài khoản và mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            cq.OpenConnection();
            try
            {
                SqlCommand cm = new SqlCommand("Select * from Login where taikhoan = @id and matkhau =@password ", cq.GetConn());
                cm.Parameters.AddWithValue("@id", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPassWord.Text);
                SqlDataAdapter adt = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                adt.Fill(ds);
                cq.CloseConnection();
                string us = txtUser.Text;
                string pss = txtPassWord.Text;
                string taikhoan = "";
                string matkhau = "";
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    taikhoan = row["taikhoan"].ToString().Trim();
                    matkhau = row["matkhau"].ToString().Trim();
                    quyen = int.Parse(row["phanquyen"].ToString());
                }
                int ok = string.Compare(us, taikhoan);
                int ok1 = string.Compare(pss, matkhau);
                //int ok = us.CompareTo(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                //int ok1 = pss.CompareTo(ds.Tables[0].Rows[0].ItemArray[1].ToString());
                if (ds.Tables[0].Rows.Count == 1 && ok == 0 && ok1 == 0)
                {
                    lbUser = taikhoan;
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    txtUser.Text = "";
                    txtPassWord.Text = "";
                    txtUser.Focus();
                    MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK) {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
                txtPassWord.UseSystemPasswordChar = true;
        }
    }
}
