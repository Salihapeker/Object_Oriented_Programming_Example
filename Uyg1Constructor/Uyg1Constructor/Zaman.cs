using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Constructor
{
    internal class Zaman
    {
        public int gun;
        public int ay;
        public int yil;

        public void zamaniYaz()
        {
            Console.WriteLine("{0}/{1}/{2}", gun, ay, yil);

        }

        public Zaman(int g, int a, int y)
        {
            //sinif ismi ile ayni isimde metotlardır.
            // deger döndürmezler.
            //nesne oluşturulurken çağrıldığında çalışırlar.
            gun = a;
            ay = y;
            yil = 0;
            Console.WriteLine("PARAMETRELI CONSTRUCTOR CALISTI. ");


        }

        public Zaman()
        {
            gun = DateTime.Now.Day;
            ay = DateTime.Now.Month;
            yil = DateTime.Now.Year;

            Console.WriteLine("Parametresiz constructor calisti. ");
        }

        static Zaman()
        {
            //static  const larda erisim seviyesi tanımlanmaz
            //static const lar parametresiz olmalı, parametre almaz
            Console.WriteLine("Statik const calisti. ");
            //statik const bir defa calisir ve ilk calisan constructordır.
            //sinifa bi çağrı yapılmadan calismio.
        }

    }
}
