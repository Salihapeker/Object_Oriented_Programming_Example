using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class LaserSilah:Decorator
    {
        public override void atesEt()
        {
            base.atesEt();
            Console.WriteLine("Laser atış");
        }
    }

    class TurboSilah : Decorator
    {
        public override void atesEt()
        {
            base.atesEt();
            Console.WriteLine("Turbo Atış");
        }
    }

}
