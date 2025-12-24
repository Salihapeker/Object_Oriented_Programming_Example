using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2SealedMethod
{
    internal class A
    {
        public virtual void method()
        {
            Console.WriteLine("Anin metodu");
        }
    }

    class B : A
    {
        public override void method()
        {
            Console.WriteLine("Bnin metodu");
        }

      
    }
    class C : B
    {
        public sealed override void method()
        {
            Console.WriteLine("C nin metodu");
        }
    }
    class D : C
    {
        /* public override void method()
         {
             Console.WriteLine("Dnin metodu");
         }*/
        public new void method()
        {
            Console.WriteLine("Dnin metodu");
        }
    }
}
