using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExmp2
{
    class Tabanca:IAttackable
    {
        public void Attack()
        {
            Console.WriteLine("Tabanca ile atak");
        }
    }

    class Kilic : IAttackable
    {
        public void Attack()
        {
            Console.WriteLine("Kılıç ile atak");
        }

    }

    class Topuz : IAttackable
    {
        public void Attack()
        {
            Console.WriteLine("Topuz ile atak");
        }

    }
}
