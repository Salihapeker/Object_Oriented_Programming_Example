using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygRPGBuff
{
    internal class ZirhBuff: KarakterDecorator
    {
        public override int Defense()
        {
            return base.Defense() + 10;
        }
    }

    class BuyuBuff : KarakterDecorator
    {
        public override int Attack()
        {
            return base.Attack() + 15;
        }
    }

    class SilahBuff : KarakterDecorator
    {
        public override int Attack()
        {
            return base.Attack() + 5;
        }
    }

}
