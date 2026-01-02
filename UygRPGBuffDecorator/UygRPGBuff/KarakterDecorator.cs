using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygRPGBuff
{
    internal class KarakterDecorator: Karakter
    {
        protected Karakter karakter;

        public void BuffEkle(Karakter k)
        {
            karakter= k;
        }
        public override int Attack()
        {
            return karakter.Attack();
        }
        public override int Defense()
        {
            return karakter.Defense();
        }
    }
}
