using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    internal class AdresDefteri
    {
        Kişi[] kisiler = new Kişi[100];
        int kisiSayisi = 0;

        public int Ekle(string ad, string soyad, string tel, string adr)
        {
            int sonuc = -1;
            if (kisiSayisi < 100)
            {
                kisiler[kisiSayisi] = new Kişi();  //gözeneği kullanmadan önce adres değeri ata o değere
                kisiler[kisiSayisi].adi = ad;
                kisiler[kisiSayisi].soyadi = soyad;
                kisiler[kisiSayisi].tel = tel;
                kisiler[kisiSayisi].adres = adr;
                kisiSayisi++;
                sonuc = 1;

            }
            return sonuc;
        }
        public int Bul(string ad, string soyad)
        {
            int index = -1;
            for (int i = 0; i < kisiSayisi; i++)
            {
                if ((kisiler[i].adi == ad) && (kisiler[i].soyadi == soyad))
                {
                    index = i;
                }
             
            }
            return index;
        }

        public int Sil(string ad, string soyad)
        {
            int index = Bul(ad, soyad);
            if( index != -1)
            {
                for(int i = index; i < kisiSayisi -1 ; i++)
                {
                    /*   kisiler[i].adi = kisiler[i + 1].adi;
                       kisiler[i].soyadi = kisiler[i + 1].soyadi;
                       kisiler[i].tel = kisiler[i + 1].tel;
                       kisiler[i].adres = kisiler[i + 1].adres; */

                    kisiler[i] = kisiler[i + 1];

                }
                kisiler[kisiSayisi - 1] = null;
                kisiSayisi--;
            }
            return index;
        }
        //Güncelle yaz

        public int Guncelle(string ad, string soyad, string yeniTel, string yeniAdres)
        {
            int index = Bul(ad, soyad);
            if (index != -1)
            {
                kisiler[index].tel = yeniTel;
                kisiler[index].adres = yeniAdres;
            }
            return index;
        }


        public string veriUret()
        {
            string cikti = "";
            for(int i=0; i < kisiSayisi; i++)
            {
                cikti += kisiler[i].bilgiyiFormatla() + "\n";
               
            }
            return cikti;
        }
    }
   
}
