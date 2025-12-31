using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP2
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFabrikasi pf = new VeggiePizzaFabrikasi();
            IPizza p1 = pf.pizzaUret();
            PizzaFabrikasi pf2 = new KarisikPizzaFabrikasi();
            IPizza p2 = pf2.pizzaUret();
        }
    }
}
