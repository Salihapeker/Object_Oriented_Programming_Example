using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP2
{
    class VejeteryanPizza : IPizza
    {
        public void malzemeleriHazirla()
        {
            Console.WriteLine("veggie hazirla");
        }
        public void hamurHazirla()
        {
            Console.WriteLine("kalin hamur hazirla");
        }

        public void decoreEt()
        {
            Console.WriteLine("üzerini sebzelerle dekore et");
        }

        public void pisir()
        {
            Console.WriteLine("hamur kalinligina göre pisir");
        }
    }
}
