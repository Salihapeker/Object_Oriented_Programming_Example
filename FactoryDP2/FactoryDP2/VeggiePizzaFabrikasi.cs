using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP2
{
    class VeggiePizzaFabrikasi:PizzaFabrikasi
    {
        public IPizza pizzaUret()
        {
            IPizza p = new VejeteryanPizza();
            return p;
        }
    }
}
