using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Uyg2Generiic
{
    //internal class Islemler
    internal class Islemler<T> //open closed prensibi generic class 
    {
        //int[] dizi = new int[10];
        T[] dizi = new T[10];
        //string[] dizi2 = new string[10];
        int ESay = 0; //nonstatic tanımlandı. static olsaydı bütün nesneler için aynı ESay değeri olurdu. her yeni nesne türettiğimizde yeniden sıfırlanıo nonstatic olduğu için 

       // public void elemanEkle(int eleman)
        public void elemanEkle(T eleman)
        {
            dizi[ESay] = eleman;
            ESay++;
            Console.WriteLine(ESay);
        }

        //public int elemanDonder(int indis)
        public T elemanDonder(int indis)
        {
            return dizi[indis];

        }
    }
}
