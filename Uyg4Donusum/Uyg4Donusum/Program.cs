using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg4Donusum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b = 5.4;
            short s = 3;
            int a = (int)b; //explicit
                            // Console.WriteLine(sizeof(int));

            // Console.WriteLine(sizeof(double));
            a = s; // implicit
            Kesir k1 = new Kesir(5, 4);
            a =(int)k1;
            Console.WriteLine(a);

            Kesir k2 = a;
            k2.yaz();

            // Kesir k3 = 5.4;

            int c = 3 + 5;
            string c1 = "ali" + "yilmaz";
        //    Kesir k3 = k1 + k2;

        }
    }
}
