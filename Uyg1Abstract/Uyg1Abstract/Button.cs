using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Abstract
{
  abstract class Button
    {
        abstract public void turnOn();
        abstract public void turnOff();

       // abstract public int prop {  get; set; }

        public void deneme()
        {
            Console.WriteLine("deneme");
        }

        //abstract ogeler cocuk sinif tarafından mutlaka tanımlanırlar.
        //abstract ogesi olan bir sinifin tanımının basına da abstract yazılmalıdır.
        //abstract sınıflarıdan yapıcı metot ile nesne türetlemez.
        //bu siniflar miras bırakmak üzere tanımlanırlar.

      
    }
}
