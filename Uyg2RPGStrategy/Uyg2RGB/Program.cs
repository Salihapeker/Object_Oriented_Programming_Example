using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2RGB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karakter k = new Karakter(new BuyuSaldirisi());
            k.Saldir();
        }
    }
}
