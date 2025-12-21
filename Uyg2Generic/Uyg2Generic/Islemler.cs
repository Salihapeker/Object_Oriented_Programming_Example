using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2Generic
{
    internal class Islemler<T>
    {
        T[] dizi = new T[10];
        string[] dizi2 = new string[10];    

        int Esay = 0;
        public void elemanEkle(T eleman)
        {
            dizi[Esay++] = eleman;
        }
        public T elemanDondur(int indis)
        {
            return dizi[indis];
        }
    }
}
