using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_Bai1.DAO
{
    public class PhongBan
    {
        private string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        private string tenPhong;

        public string TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }
        private string maNQL;

        public string MaNQL
        {
            get { return maNQL; }
            set { maNQL = value; }
        }
        private string diaDiem;

        public string DiaDiem
        {
            get { return diaDiem; }
            set { diaDiem = value; }
        }
        public PhongBan(string ma, string ten, string manql, string diadiem)
        {
            this.MaPhong = ma;
            this.TenPhong = ten;
            this.MaNQL = manql;
            this.DiaDiem = diadiem;
        }
        
    }
}
