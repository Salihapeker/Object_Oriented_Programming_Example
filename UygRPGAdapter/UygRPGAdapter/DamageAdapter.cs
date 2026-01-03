using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygRPGAdapter
{   //Adapter
    //iki uyumsuz arayüzü birbirine bağlar.
    internal class DamageAdapter: DamageSystem
    {
        public override void Takedamage(int damage)
        {
            //Adapter içinde legacy sistem kullanılır.
            LegacyDamageSystem legacy = new LegacyDamageSystem();

            //parametre dönüşümü yapılır.
            legacy.ApplyHit(damage, "physical");
        }
    }
}
