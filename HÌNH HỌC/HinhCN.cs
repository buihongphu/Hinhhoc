using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HÌNH_HỌC
{
    class HinhCN : Hìnhhọc
    {
        protected float chieudai;
        private float chieurong;

        public float ChuVi;
        public float DienTich;
        public float dai
       {
            get {return chieudai; }
            set { chieudai = value; }
        }
        public float rong
      {
        get { return chieurong;}
        set { chieurong = value;}
      }
        public HinhCN( float dai , float rong)
        { 
            chieudai = dai;
            chieurong = rong;
        }
        public HinhCN() {}
        public void chuvi()
        {
            ChuVi = (chieudai + chieurong) * 2;
        }
            public void dientich()
        {
            DienTich = chieudai * chieurong;
        }
            
    }
}
