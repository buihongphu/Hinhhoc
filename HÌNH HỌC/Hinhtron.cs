using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HÌNH_HỌC
{
    class Hinhtron : Hìnhhọc
    {
        private const float pi = 3.14f;
        private float r;

        public float ChuVi;
        public float DienTich;

        public float BanKinh
        {
            get { return r; }
            set { r = value; }
        }

        public Hinhtron(){}
        public Hinhtron(float r) 
        {
            this.r = r;
        }
        public void chuvi()
        {
            ChuVi = r * 2 * pi;
        }

        public void dientich()
        {
            DienTich = 2 * pi * (r * r);
        }

    }
}
