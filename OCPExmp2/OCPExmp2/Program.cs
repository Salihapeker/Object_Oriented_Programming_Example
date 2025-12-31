using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExmp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu o = new Oyuncu();
            Tabanca t = new Tabanca();
            o.silahEkle(t);
            Kilic k = new Kilic();
            o.silahEkle(k);
            o.tekliSilahSaldiri(k);
            o.FullSaldiri();
        }
    }
}
