using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygRPGBuff
{
    internal class Karakter
    {
        public virtual int Attack()
        {
            return 10;
        }
        public virtual int Defense()
        {
            return 5;
        }
    }
}
