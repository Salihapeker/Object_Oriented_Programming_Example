using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2SealedMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
           // a.method();  //A
            
            B b = new B();
          //  b.method(); //B


            D d = new D();
          //  d.method(); //D // D yi çağırmak için kabuk üzerinden çağırmamız gerekir

            A[] dizi =new A[5];
          /*  dizi[0] = new A(); //A
            dizi[1] = new B(); //B
            dizi[2] = new C(); //C
            dizi[3] = new D(); //C
            dizi[4] = new A(); //A */

            dizi[0] = new B(); //B
            dizi[1] = new B(); //B
            dizi[2] = new C(); //C
            dizi[3] = new D(); //C
            dizi[4] = new C(); //C
            for (int i = 0; i < 5; i++)
            {
                dizi[i].method();
            }

        }
    }
}
