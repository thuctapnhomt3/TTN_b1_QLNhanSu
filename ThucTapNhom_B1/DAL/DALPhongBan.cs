using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhongBan:ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("select * from phongban");
        }
        public bool Them(PhongBan pb)
        {
            try
            {
                string query = @"INSERT INTO dbo.PhongBan( MaPhong ,TenPhongBan , MaNQL ,DiaDiem)
                                VALUES  ( '" + pb.Ma + "',N'" + pb.Ten + "', '" + pb.MaQL + "',N'" + pb.DiaDiem + "')";
                OpenConection();
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                 SetEx(ex);
                return false;
            }
        }
        public bool Sua(PhongBan pb)
        {
            try
            {
                string query = @" UPDATE dbo.PhongBan set tenphongban = N'" + pb.Ten + "',manql = '" + pb.MaQL + "', diadiem = N'" + pb.DiaDiem + "' where maphong ='" + pb.Ma + "'";
                OpenConection();
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public bool Xoa(String ma)
        {
            try
            {
                string query = @"Delete from PhongBan where maphong='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE FROM dbo.DeAn WHERE MaPhong = '"+ma+"'");
                ExecuteQueries(@"DELETE FROM dbo.NhanVien WHERE MaPhong = '" + ma + "'");
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            try
            {
                //string query = @"select * from NhanVien where (manv like '%" + chuoi + "%' or ten like N'%" + chuoi + "%' or maphong like '%" + chuoi + "%' or gioitinh like N'%" + chuoi + "%' or luong like '%" + chuoi + "%'or diachi like N'%" + chuoi+ "% or ngaysinh like '%" + DateTime.Parse(chuoi) +"')";
                string query = @"select * from PhongBan where (maphong like '%" + chuoi + "%' or tenphongban like N'%" + chuoi + "%' or manql like '%" + chuoi + "%' or diadiem like N'%" + chuoi + "%')";
                return (DataTable)ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return null;
            }
        }
    }
}
