using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3IntsizAbs
{
    internal class DansToplulugu
    {
        DansEdebilenler[] danscilar = new DansEdebilenler[10];
        int eklenen = 0;


        public void dansciEkle(DansEdebilenler dansci)
        {
            danscilar[eklenen] = dansci;
        }
        public void dansBaslasin()
        {
            for (int i = 0; i < eklenen; i++) 
            {
                danscilar[i].dansEt();
            }

        }
    }
}
