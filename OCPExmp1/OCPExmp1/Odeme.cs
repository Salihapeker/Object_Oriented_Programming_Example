using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExmp1
{
    class Odeme
    {

        public void Ode(OdemeYontemi o, int miktar)
        {
            o.Ode(miktar);
        }
    }

    class CreditCard:OdemeYontemi
    {

        public void Ode(int miktar)
        {
            Console.WriteLine("Kredi kartı ile ödendi");
        }
    }

    class Cash:OdemeYontemi
    {
        public void Ode(int miktar)
        {
            Console.WriteLine("Nakit ödendi");
        }
    }

    class Havale:OdemeYontemi
    {
        public void Ode(int miktar)
        {
            Console.WriteLine("Havale ile ödendi");
        }
    }

    interface OdemeYontemi
    {
        void Ode(int a);
    }

    class EFT : OdemeYontemi
    {
        public void Ode(int miktar)
        {
            Console.WriteLine("EFT ile ödendi");

        }
    }
}
