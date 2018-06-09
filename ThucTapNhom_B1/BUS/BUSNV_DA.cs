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
    public class BUSNV_DA
    {
        DALNV_DA dal_nvda = new DALNV_DA();
        public DataTable GetData()
        {
            return dal_nvda.GetData();
        }
        public bool Them(NVDA nvda)
        {
            return dal_nvda.Them(nvda);
        }
        public bool Sua(NVDA nvda,string mada, string manv)
        {
            return dal_nvda.Sua(nvda, mada, manv);
        }
        public Exception GetEx()
        {
            return dal_nvda.GetEx();
        }
        public void SetEx(Exception ex)
        {

        }
        public bool Xoa(string manv, string mada)
        {
            return dal_nvda.Xoa(manv,mada);
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            return dal_nvda.GetDataTimKiem(chuoi);
        }
        public DataTable GetDataComNV()
        {
            return dal_nvda.GetDataComNV();
        }
        public DataTable GetDataComDA()
        {
            return dal_nvda.GetDataComDA();
        }
    }
}
