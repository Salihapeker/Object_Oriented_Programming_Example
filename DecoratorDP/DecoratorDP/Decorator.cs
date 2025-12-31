using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    class Decorator:Silah
    {
        protected Silah temelSilah;

        public void BilesenEkle(Silah bilesen)
        {
            temelSilah = bilesen;
        }

        public override void atesEt()
        {
            //base.atesEt();
            temelSilah.atesEt();
        }
    }
}
