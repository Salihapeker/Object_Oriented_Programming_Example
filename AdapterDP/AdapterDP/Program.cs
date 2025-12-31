using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Onceki o = new Adapter();
            o.sarjEt(8);
        }
    }
}
