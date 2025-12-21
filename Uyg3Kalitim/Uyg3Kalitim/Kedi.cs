using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Kalitim
{
    internal class Kedi:Varlik
    {
        public string turu;

        public void fareYakalama()
        {
            Console.WriteLine("Fare yakaalndı");
        }
        public Kedi() {
            Console.WriteLine("Kedi nesnesi olustu.");

        }

        public new void sesVer()
        {
            Console.WriteLine("Miyavv");
        }

        public override void yuru()
        {
            Console.WriteLine("Dort ayakli yuruo");
        }
        public void deneme() 
        {
            yas = 5; // ata sınıfı içindeki public bir değişkene çocuk sınıfın içinden erişebilioruz.
           // privDegisken = 3;
           // privMethod();
            protDegisken = 1;
            protMetot();
        }

    }
}
