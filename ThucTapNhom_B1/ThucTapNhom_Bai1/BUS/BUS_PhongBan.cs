using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTapNhom_Bai1.DAL;
using ThucTapNhom_Bai1.DAO;

namespace ThucTapNhom_Bai1.BUS
{
    class BUS_PhongBan
    {
        DAL_PhongBan dalPhongBan = new DAL_PhongBan();
        public bool Them(PhongBan pb)
        {
            return dalPhongBan.Them(pb);
        }
        public bool Sua(PhongBan pb)
        {
            return dalPhongBan.Sua(pb);
        }
        public bool Xoa(string ma)
        {
            return dalPhongBan.Xoa(ma);
        }
        public object GetData()
        {
            return dalPhongBan.GetData();
        }
    }
}
