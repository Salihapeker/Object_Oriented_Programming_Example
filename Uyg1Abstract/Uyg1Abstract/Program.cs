using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Button b = new Button();
           // b.turnOff;
            KatButonu kb = new KatButonu();
            kb.turnOn();
            kb.turnOff();

            Button b = kb; //cocuk sınıfı ata sınıf yerine koyulabilir.
                           //her kat butonu aslında bit butondur. LISKOV prensibine uymakta.

            /*KatButonu kb = new KatButonu();
            Button b = kb;
            yukarıdaki iki satırı aşağıdaki tek satır karşılar.
            Button b2 = new KatButonu(); */

            KalitimaKapaliSinif ks = new KalitimaKapaliSinif();
            ks.deneme();
        }
    }
}
