using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DeAn
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
        private int sogio;

        public int SoGio
        {
            get { return sogio; }
            set { sogio = value; }
        }
        private string maphong;

        public string MaPhong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        public DeAn(string ma, string ten, int sogio, string maphong)
        {
            this.ma = ma;
            this.ten = ten;
            this.sogio = sogio;
            this.maphong = maphong;
        }

    }
}
