using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExmp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard a = new CreditCard();
            Odeme odemeNesnesi = new Odeme();
            Cash c = new Cash();
            Havale h = new Havale();
            EFT e = new EFT();
            odemeNesnesi.Ode(e,100);

        }
    }
}
