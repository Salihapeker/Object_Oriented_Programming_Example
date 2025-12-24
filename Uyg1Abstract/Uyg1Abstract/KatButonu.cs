using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Abstract
{
    internal class KatButonu:Button
    {
        public override void turnOff()
        {
            Console.WriteLine("katbutonu kapandi");
        }

        public override void turnOn()
        {
            Console.WriteLine("katbutonu yandi");
        }
    }
}
