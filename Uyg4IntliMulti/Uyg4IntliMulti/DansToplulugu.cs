using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg4IntliMulti
{
    internal class DansToplulugu
    {
        IDansEdebilenler[] topluluk = new IDansEdebilenler[10];


        int eklenen = 0;
        public void dansciEkle(IDansEdebilenler dansci)
        {
            topluluk[eklenen++] = dansci;
        }
        public void dansBaslasin()
        {
            for (int i = 0; i < eklenen; i++)
            {
                topluluk[i].dansEt();
            }

        }
    }
}
