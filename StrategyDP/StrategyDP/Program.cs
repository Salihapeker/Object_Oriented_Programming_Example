using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Siralama s = new Siralama(new QuickSort());
            s.islem();
        }
    }
}
