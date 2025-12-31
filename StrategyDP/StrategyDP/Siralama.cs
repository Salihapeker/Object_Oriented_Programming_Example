using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class Siralama
    {
        ISortStrategy siralamaYontemi;
        public Siralama(ISortStrategy sy)
        {
            siralamaYontemi = sy;
        }

        public void islem()
        {
            siralamaYontemi.sirala();
        }
    }
}
