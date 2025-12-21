using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2Generiic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Islemler d = new Islemler();
           // d.elemanEkle(3);
           // int c = d.elemanDonder(0);

            Islemler <int> d1 = new Islemler<int>();
            d1.elemanEkle(5);
            d1.elemanEkle(3);

            Islemler<String> d2 = new Islemler<String>();
            d2.elemanEkle("ali");
            d2.elemanEkle("batu");
            d2.elemanEkle("akay");

            Islemler<Kitap> d3 = new Islemler<Kitap>();
            d3.elemanEkle(new Kitap());
            Kitap k1 = new Kitap();
            d3.elemanEkle(k1);


        }
    }
}
