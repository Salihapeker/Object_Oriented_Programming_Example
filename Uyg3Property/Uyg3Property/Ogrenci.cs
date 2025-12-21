using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Property
{
    internal class Ogrenci
    {
        private int yas;
        private int dYili;

        public bool yasAta(int y)
        {
            bool sonuc = false;
            //berlirleiğimz kısıtların sağlanıp sağlanmadğı burada kontrol edilir
            if ((y >= 18) & (y < 100))
            {
                yas = y;
                dYili = DateTime.Now.Year - y;
                sonuc = true;

            }
            return sonuc;

        }
        public int yasDonder()
        {
            return yas;
        }

        public void dYiliAta(int dy)
        {
            if (dy <= DateTime.Now.Year)
            {
                dYili = dy;
                yas = DateTime.Now.Year - dy;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
        public int dYiliDonder()
        {
            return dYili;
        }

    }
}
