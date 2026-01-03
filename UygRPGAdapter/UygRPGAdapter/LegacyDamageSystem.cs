using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygRPGAdapter
{
    //Adaptee
    //Harici(legacy) hasar sistemi
    internal class LegacyDamageSystem
    {
        public void ApplyHit(float power, string damageType)
        {
            Console.WriteLine($"hasar alindi: {power} {damageType}");
        }
        //bu sınıf değiştirilemez. (third - party)
    }
}
