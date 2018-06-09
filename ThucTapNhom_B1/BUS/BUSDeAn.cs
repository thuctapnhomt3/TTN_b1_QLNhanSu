using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSDeAn
    {
        DALDeAn dal_da = new DALDeAn();
        public DataTable GetData()
        {
            return dal_da.GetData();
        }
        public bool Them(DeAn da)
        {
            return dal_da.Them(da);
        }
        public bool Sua(DeAn da)
        {
            return dal_da.Sua(da);
        }
        public Exception GetEx()
        {
            return dal_da.GetEx();
        }
        public void SetEx(Exception ex)
        {

        }
        public bool Xoa(string ma)
        {
            return dal_da.Xoa(ma);
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            return dal_da.GetDataTimKiem(chuoi);
        }
        public DataTable GetDataCom()
        {
            return dal_da.GetDataCom();
        }
    }
}
