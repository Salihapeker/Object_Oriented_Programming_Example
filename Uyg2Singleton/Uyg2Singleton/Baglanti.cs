using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2Singleton
{
    class Baglanti
    {
        private Baglanti() 
        {

        }

        static Baglanti b;
        static Baglanti()
        {
            b = new Baglanti();

        }

        public static Baglanti BaglantiDonder()
        {
            return b;
        }
    }
}
