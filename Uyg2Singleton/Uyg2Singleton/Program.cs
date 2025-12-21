using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif s1 = new Sinif();
            s1.a = 5;
            Sinif s2 = s1; // ayni adrese atadık. esit
            //  Sinif s2 = new Sinif();  //2 nesne varsa adreslerini karsilastirir esit degil
            s2.a = 5;

            if (s1 == s2) 
            
                Console.WriteLine("Nesneler esit");
            else
                    Console.WriteLine("esit degil");

            /* Baglanti b1 = new Baglanti();
             Baglanti b2 = new Baglanti();
             Baglanti b3 = new Baglanti(); */

            Baglanti b1 = Baglanti.BaglantiDonder();
            Baglanti b2 = Baglanti.BaglantiDonder();
            Baglanti b3 = Baglanti.BaglantiDonder();

            if (b1 == b2)
                Console.WriteLine("nesneler ayni adresi gösterior");
            else Console.WriteLine("farkli nesneler");

            //SINGLETON DESIGN PATTERN


        }
    }

    class Sinif
    {
        public int a;
    }
}
