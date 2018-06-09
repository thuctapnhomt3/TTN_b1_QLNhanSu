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
    public class BUSPhongBan
    {
        DALPhongBan dal_pb = new DALPhongBan();
        public DataTable GetData()
        {
            return dal_pb.GetData();
        }
        public bool Them(PhongBan pb)
        {
            return dal_pb.Them(pb);
        }
        public bool Sua(PhongBan pb)
        {
            return dal_pb.Sua(pb);
        }
        public Exception GetEx()
        {
            return dal_pb.GetEx();
        }
        public void SetEx(Exception ex)
        {
            
        }
        public bool Xoa(string ma)
        {
            return dal_pb.Xoa(ma);
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            return dal_pb.GetDataTimKiem(chuoi);
        }
        
    }
}
