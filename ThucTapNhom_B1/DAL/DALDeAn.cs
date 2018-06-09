using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDeAn : ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("select mada,tenda,sogio,dean.maphong,tenphongban from DeAn,phongban where dean.maphong = phongban.maphong");
        }
        public DataTable GetDataCom()
        {
            return (DataTable)ShowDataInGridView("select maphong,tenphongban from phongban");
        }
        public bool Them(DeAn da)
        {
            try
            {
                string query = @"INSERT INTO dbo.DeAn( MaDA, TenDa, SoGio, MaPhong)
                                VALUES  ( '" + da.Ma + "',N'" + da.Ten + "', '" + da.SoGio + "','" + da.MaPhong + "')";
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
        public bool Sua(DeAn da)
        {
            try
            {
                string query = @" UPDATE dbo.DeAn set TenDA = N'" + da.Ten + "',maphong = '" + da.MaPhong + "', sogio = '" + da.SoGio + "' where mada ='" + da.Ma + "'";
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

                string query = @"DELETE FROM dbo.DeAn WHERE MaDa='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE FROM dbo.NV_DA WHERE MaDA  = '" + ma + "'");
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
                string query = @"select * from dean where (mada like '%" + chuoi + "%' or tenda like N'%" + chuoi + "%' or maphong like '%" + chuoi + "%')";
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
