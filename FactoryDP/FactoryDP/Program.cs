using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaDukkani dukkan = new PizzaDukkani();
            IPizza p = new KarisikPizza();
            dukkan.Uret(p);
            IPizza p2 = new VegeteryanPizza();
            dukkan.Uret(p2);

        }
    }
}
