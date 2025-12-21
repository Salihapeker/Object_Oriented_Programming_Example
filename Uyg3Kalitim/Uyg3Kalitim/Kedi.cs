using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Kalitim
{
    internal class Kedi:Varlik
    {
        public Kedi() {
            Console.WriteLine("Kedi nesnesi olustu.");

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
