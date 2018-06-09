using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ThucTapNhom_Bai1.DAO;

namespace ThucTapNhom_Bai1.DAL
{
    class DAL_PhongBan : Connection_Query
    {
       
        
        private DataTable Get()
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from PhongBan", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            
        }
        public DAL_PhongBan()
        {
            dt = Get();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public object GetData()
        {
            return ShowDatainGridView("select * from phongban");
        }
        
        DataTable dt = new DataTable();
        public bool Them(PhongBan pb)
        {
            string query = "INSERT INTO dbo.PhongBan ( MaPhong, TenPhong, MaNQL, DiaDiem )VALUES  ('"+pb.MaPhong+"',N'"+pb.TenPhong+"',N'"+pb.MaNQL+"',N'"+pb.DiaDiem+"')";
            if (ExecuteQueries(query)== true)
                return true;
            else
                return false;
        }
        public bool Xoa(string ma)
        {
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter("select * from PhongBan", InitialCon());
                //OpenConnection();
                //DataRow dr = dt.Rows.Find(ma);
                //if (dr != null)
                //{
                //    dr.Delete();
                //}
                //SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                //da.Update(dt);
                //CloseConnection();
                SqlCommand cmd = new SqlCommand("delete phongban where maphong=@id", con);
                OpenConnection();
                cmd.Parameters.AddWithValue("@id", ma);
                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(PhongBan pb)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhongBan",con );
                OpenConnection();
                DataRow dr = dt.Rows.Find(pb.MaPhong);
                if (dr != null)
                {
                    dr["TenPhongBan"] = pb.TenPhong;
                    dr["MaNQL"] = pb.MaNQL;
                    dr["DiaDiem"] = pb.DiaDiem;
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(dt);
                CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
