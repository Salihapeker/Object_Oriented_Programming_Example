using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class SelectionSort:ISortStrategy
    {
        public void sirala()
        {
            Console.WriteLine("Selection Sort yapildi");
        }
    }

    class BubbleSort : ISortStrategy
    {
        public void sirala()
        {
            Console.WriteLine("Bubble sort yapildi");
        }
    }
}
