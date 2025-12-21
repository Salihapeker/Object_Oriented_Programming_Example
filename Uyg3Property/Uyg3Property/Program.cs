using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();
            //  o1.yas = 120;
            bool s = o1.yasAta(30);
            //Console.WriteLine(s);
           // Console.WriteLine(o1.yasDonder());

            o1.dYiliAta(2022);
           // Console.WriteLine(o1.yasDonder());
           // Console.WriteLine(o1.dYiliDonder());
           // int c = 01.yas();

            Ogrenci2 o2 = new Ogrenci2();
            o2.PYas = 20;
            Console.WriteLine(o2.PYas);
            o2.PDYili = 1985;
            Console.WriteLine(o2.PDYili);
            Console.WriteLine(o2.PYas);
            Console.WriteLine(o2.PGano);

        }
    }
}
