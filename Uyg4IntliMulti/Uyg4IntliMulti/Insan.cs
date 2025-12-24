using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg4IntliMulti
{
    internal class Insan:ISesVerebilenler, IDansEdebilenler
    {
      //  public new void sesVer() new yazmamıza gerek yok yine
        public void sesVer()
        {
            Console.WriteLine("Doremifasol");
        }

        public void dansEt()
        {
            Console.WriteLine("O zaman dans");
        }
    }
}
