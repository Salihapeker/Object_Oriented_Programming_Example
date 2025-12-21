using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg4Donusum
{
  
    internal class Kesir
    {
        public int pay;
        public int payda;
        public Kesir(int p, int pd) 
        {
            pay = p;
            payda = pd;

        }

        public void yaz()
        {
            Console.WriteLine("{0}/{1}", pay ,payda);

        }

        // public static explicit operator olusanTip(DonusenTip)
        // public static explicit operator neye(neyi)

        public static explicit operator int(Kesir k)
        {
            int sonuc = k.pay / k.payda;
            return sonuc;
        }

        public static implicit operator Kesir(int sayi)
        {
            Kesir sonuc = new Kesir((int)sayi, 1);
            return sonuc;
        }
        // double int tanımlı olduğu için
    }
}
