using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2RGB
{
    internal class Karakter
    {
        ISaldiri saldiriTuru;
        //Constructor ile  strategy enjekte edilir. 
        public Karakter(ISaldiri s)
        {
            saldiriTuru = s;
        }

        public void Saldir()
        {
            saldiriTuru.Saldir();
        }
        //Karakter saldiri algoritmasını bilmez sadece kullanır.
    }
}
