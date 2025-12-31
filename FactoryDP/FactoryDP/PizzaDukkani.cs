using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    class PizzaDukkani
    {
        public void Uret(IPizza k)
        {
            k.malzemeleriHazirla();
            k.hamurHazirla();
            k.decoreEt();
            k.pisir();

        }
    }
}
