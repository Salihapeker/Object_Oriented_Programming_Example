using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Silah s = new Silah();
            Decorator d1 = new TurboSilah();
            d1.BilesenEkle(s);
        //    d1.atesEt();

            Decorator d2 = new LaserSilah();
            d2.BilesenEkle(d1);
            d2.atesEt();
        }
    }
}
