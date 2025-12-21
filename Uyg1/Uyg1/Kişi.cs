using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    internal class Kişi
    {
        //attribute tanımı erişim seviyesi static/nonstatic tip degisken/nesneAdi
        //metot tanımı erişim seviyesi static/nonstatic donderdigiTip metotAdi(parametreTip parametreAdi,...)
        //{}

        public string adi;
        public string soyadi;
        public string tel;
        public string adres;

        public string bilgiyiFormatla()
        {
            string cikti = "Adi: " + adi + "soyadi: " + soyadi + "Tel: " + tel + "Adres: " + adres;
            return cikti;
        }

    }
}
