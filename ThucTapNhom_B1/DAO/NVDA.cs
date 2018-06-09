using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NVDA
    {
        private string manv;

        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        private string mada;

        public string MaDA
        {
            get { return mada; }
            set { mada = value; }
        }
        public NVDA(string manv, string mada)
        {
            this.manv = manv;
            this.mada = mada;
        }


    }
}
