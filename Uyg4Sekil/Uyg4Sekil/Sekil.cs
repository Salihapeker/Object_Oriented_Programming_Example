
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uyg4Sekil
{
    internal class Sekil
    {

        public virtual void Ciz()
        {
            Console.WriteLine("Sekil Cizildi");
        }
    }

    class Daire : Sekil
    {
        public new void Ciz()
        {
            Console.WriteLine("Daire cizildi");
        }
    }
    class Ucgen : Sekil { }

    class Kare : Sekil { 
        public override void Ciz()
        {
            Console.WriteLine("Kare cizildi");
        }
    }
}
