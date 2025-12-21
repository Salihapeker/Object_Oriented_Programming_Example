using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap();
            k1.kitapAdi = "Empati";
            k1.yazar = "Adam Faver";
            k1.OduncVer();

            Kitap k2 = new Kitap();
            k2.kitapAdi = "Sefiller";
            k2.yazar = "Victor Hugo";
            k2.OduncVer();

            Kitap k3 = new Kitap();
            k3.kitapAdi = "1984";
            k3.yazar = "Geroge Orwell";
            k3.OduncVer();

            Kitap k4 = new Kitap();
            k4.kitapAdi = "Outliers";
            k4.yazar = "Malcolm Gladwell";
            k4.OduncVer();
        }

    }
}
