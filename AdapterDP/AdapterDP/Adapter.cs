using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    class Adapter:Onceki
    {
        public override void sarjEt(int a)
        {
            base.sarjEt(a);
            AdapteEdilen nesne = new AdapteEdilen();
            nesne.Calistir(3,5);
        }
    }
}
