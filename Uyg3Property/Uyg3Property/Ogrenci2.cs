using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Property
{
    internal class Ogrenci2
    {
        int yas;
        int dYili;

        public int PYas
        {
            get { return yas; } //yasDonder metodu gibi çalışır. içerdeki belli bir değişkenin veya
                                //hesaplanan değerin dönderilmesini sağlar.return komutunu kullanır. 
            set
            {
                if ((value >= 18) && (value < 100))
                {
                    yas = value;
                    dYili = DateTime.Now.Year - value;
                }

            }// yasAta metodu gibi çalışır kullanıcının atadığı değeri alarak işlem yapar
             // disaridan atanan değer value isimli özel değişkende tutulur.
        }
            public int PDYili
        {
            get { return dYili; }
            set
            {if (value <= DateTime.Now.Year)
            {
                    dYili = value;
                    dYili = DateTime.Now.Year - dYili;
                }
            }
        }

        int[] notlar = new int[5] { 35, 65, 75, 43, 88 };
        public double PGano { get {
                double ort = 0;
                for (int i = 0; i < notlar.Length; i++)
                    ort += notlar[i];
                ort = ort/notlar.Length;
                return ort;
            }
        
        }
    }
}
