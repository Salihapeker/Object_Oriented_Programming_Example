using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg5ArraySrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] dizi = new int[] { -2, 3, 0, 5, 20, 1, -10 };
            /* string[] dizi = new string[] { "ayse","ali", "ahmet", "mehmet", "deniz", "lale" };

              Console.WriteLine("sıralama öncesi");
              for(int i = 0; i < dizi.Length; i++)
                  Console.WriteLine(dizi[i]);

              Array.Sort(dizi);
              Console.WriteLine("sıralama sonrasi");
              for (int i = 0; i < dizi.Length; i++)
                  Console.WriteLine(dizi[i]);*/

            Personel[] dizi = new Personel[5];
            dizi[0] = new Personel(105, "ali", "demir");
            dizi[1] = new Personel(100, "ahmet", "gunes");
            dizi[2] = new Personel(102, "ayse", "lale");
            dizi[3] = new Personel(101, "mehmet", "celik");
            dizi[4] = new Personel(110, "fatma", "deniz");
            Console.WriteLine("siralama oncesi");
            for (int i = 0; i < 5; i++) 
            dizi[i].yaz();
            Array.Sort(dizi);
            Console.WriteLine("siralama sonrasi");
            for (int i = 0; i < 5; i++)
                dizi[i].yaz();
        }
    }
}
