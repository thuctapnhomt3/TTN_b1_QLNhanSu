using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongBan
    {
        private string ma;

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private string maql;

        public string MaQL
        {
            get { return maql; }
            set { maql = value; }
        }
        private string diadiem;

        public string DiaDiem
        {
            get { return diadiem; }
            set { diadiem = value; }
        }
        public PhongBan()
        {
            this.ma = this.ten = this.maql = this.diadiem = "";
        }
        public PhongBan(string ma, string ten, string maql, string diadiem)
        {
            this.ma = ma;
            this.ten = ten;
            this.maql = maql;
            this.diadiem = diadiem;
        }
    }
}
