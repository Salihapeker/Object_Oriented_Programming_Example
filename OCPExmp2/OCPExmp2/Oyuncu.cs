using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExmp2
{
    class Oyuncu
    {
        IAttackable[] silahlar = new IAttackable[5];
        int ss = 0;
        public void silahEkle(IAttackable saldiriNesnesi)
        {
            silahlar[ss++] = saldiriNesnesi;
        }

        public void tekliSilahSaldiri(IAttackable saldiriNesnesi)
        {
            saldiriNesnesi.Attack();
        }

        public void FullSaldiri()
        {
            for (int i = 0; i < ss; i++)
                silahlar[i].Attack();
        }
    }
}
