using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygRPGBuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karakter k = new Karakter();

            ZirhBuff zirh = new ZirhBuff();
            zirh.BuffEkle(k);

            BuyuBuff buyu = new BuyuBuff();
            buyu.BuffEkle(zirh);

            SilahBuff silah = new SilahBuff();
            silah.BuffEkle(buyu);

            Console.WriteLine("Attack: " + silah.Attack());
            Console.WriteLine("Defense: " + silah.Defense());
        }
    }
}
