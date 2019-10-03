using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HÌNH_HỌC
{
    class Hìnhvuông: HinhCN
    {
        public float ChuVi;
        public float DienTich;
        private int p1;
        private int p2;

        public float Canh
        {
            get { return chieudai; }
            set { chieudai = value; }
        }

        public Hìnhvuông() { }

        public Hìnhvuông(float canh)
        {
            chieudai = canh;
        }

        public Hìnhvuông(int p1, int p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }

        public void chuvi()
        {
            ChuVi = dai * 4;
        }
        public void dientich()
        {
            DienTich = dai * dai;
        }
            
    }
}
