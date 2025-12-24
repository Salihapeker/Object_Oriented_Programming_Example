using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg5ArraySrt
{
    internal class Personel: IComparable
    {
        public int sicilNo;
        public string adi;
        public string soyadi;

        public Personel(int sn, string a, string s)
        {
            sicilNo = sn;
            adi = a;
            soyadi = s;
        }

        public void yaz()
        {
            Console.WriteLine("{0}:{1} {2}", sicilNo, adi, soyadi);
        }
        public int CompareTo(object o)
        {
            Personel p = (Personel)o;
            return adi.CompareTo(p.adi); // hangi fieldla karşılaştırma yapılacak onu tanımlıoruz.
          //  return sicilNo.CompareTo(p.sicilNo);
        }
    }
}
