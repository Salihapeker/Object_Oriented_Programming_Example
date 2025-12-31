using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExmp2
{
    class Kalkan:IAttackable,IDefendable
    {
        public void Attack()
        {
            Console.WriteLine("Kalkanla atak");
        }

        public void defense()
        {
            Console.WriteLine("Kalkan ile defense");
        }
    }
}
