using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNV_DA:ClassConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("select ten,nv_da.manv, tenda,nv_da.mada from nhanvien, dean,nv_da where nhanvien.manv = nv_da.manv and nv_da.mada = dean.mada");
        }
        public DataTable GetDataComNV()
        {
            return (DataTable)ShowDataInGridView("select manv,ten from nhanvien");
        }
        public DataTable GetDataComDA()
        {
            return (DataTable)ShowDataInGridView("select mada,tenda from Dean");
        }
        public bool Them(NVDA nvda)
        {
            try
            {
                string query = @"INSERT INTO dbo.NV_DA( MaNV ,MaDA)
                                VALUES  ( '" + nvda.MaNV + "','" + nvda.MaDA + "')";
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
        public bool Sua(NVDA nvda, string mada, string manv)
        {
            try
            {
                string query = @" UPDATE dbo.NV_DA set mada = '" + mada + "', manv = '" + manv + "' where manv ='" + nvda.MaNV + "' AND mada = '" + nvda.MaDA + "'";
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
        public bool Xoa(string manv, string mada)
        {
            try
            {
                string query = @"Delete from NV_DA where manv='" + manv + "' and mada = '"+mada+"'";
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
        public DataTable GetDataTimKiem(string chuoi)
        {
            try
            {
                //string query = @"select * from NhanVien where (manv like '%" + chuoi + "%' or ten like N'%" + chuoi + "%' or maphong like '%" + chuoi + "%' or gioitinh like N'%" + chuoi + "%' or luong like '%" + chuoi + "%'or diachi like N'%" + chuoi+ "% or ngaysinh like '%" + DateTime.Parse(chuoi) +"')";
                string query = @"select * from NV_DA where (mada like '%" + chuoi + "%' or manv like '%" + chuoi + "%')";
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
