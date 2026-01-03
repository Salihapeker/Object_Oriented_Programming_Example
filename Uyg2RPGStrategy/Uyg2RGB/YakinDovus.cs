using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2RGB
{
    internal class YakinDovus :ISaldiri
    {

        public void Saldir()
        {
            Console.WriteLine("Yakin dovus saldirisi yapildi.");
        }
            
    }

    class OkSaldirisi : ISaldiri
    {
        public void Saldir()
        {
            Console.WriteLine("Ok ile saldırı yapıldı");
        }
    }

    class BuyuSaldirisi : ISaldiri
    {
        public void Saldir()
        {
            Console.WriteLine("Büyü saldırısı yapıldı");
        }
    }
}
