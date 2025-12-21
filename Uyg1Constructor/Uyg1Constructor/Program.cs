using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
           // Console.WriteLine(a);
            bool b = new bool();
           // Console.WriteLine(b);

            /*Zaman z1 = new Zaman(); //parametreli constructor varsa calismaz
            z1.gun = 10;
            z1.ay = 10;
            z1.yil = 2004; 
            z1.zamaniYaz();*/
            Zaman z2 = new Zaman(16,5, 2005);
           // z2.zamaniYaz();

            Zaman z3 = new Zaman();
           // z3.zamaniYaz();

            Zaman z4 = new Zaman();

        }
    }
}
