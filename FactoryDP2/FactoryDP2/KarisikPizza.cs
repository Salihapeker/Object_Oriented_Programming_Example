using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP2
{
    class KarisikPizza : IPizza
    {
        public void malzemeleriHazirla()
        {
            Console.WriteLine("karisik malz hazirla");
        }
        public void hamurHazirla()
        {
            Console.WriteLine("ince hamur hazirla");
        }

        public void decoreEt()
        {
            Console.WriteLine("üzerini karisik dekore et");
        }

        public void pisir()
        {
            Console.WriteLine("az pisir");
        }
    }
}
