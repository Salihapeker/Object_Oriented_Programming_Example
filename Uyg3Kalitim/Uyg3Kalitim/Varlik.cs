using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Kalitim
{
    internal class Varlik
    {
        public int yas;
        public int agirlik;
        private int privDegisken;

        protected int protDegisken;

        private void privMetot()
        {
            protDegisken = 1;
        }

        protected void protMetot()
        {

        }
        public Varlik()
        {
            Console.WriteLine("Varlik nesnesi olusturuldu");
        }
        public virtual void yuru()
        {
            Console.WriteLine("Varlik gibi yuruo");
        }

        public void sesVer() {
            Console.WriteLine("Varlik gibi ses verio");
        }

    }
}
