using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          /*   Varlik v1 = new Varlik(); //sadece bu çalıştığında varlık nesnesi olusturulduu çıktısı alırız
                                       // v1.privDegisken = 1;//private olan ogeler ne cocuk sinif içinden ne de cocuk sınıfın nesnesi üzerinden erişiemezler.
                                       // v1.protDegisken = 5;
            v1.yuru();
            v1.sesVer();*/
            Kedi k1 = new Kedi(); // sadece bunu çalıştırdığımızda varlık nesnesi olusturuldu ve kedi nest-nesi olustu çoktısı alırız. 
            k1.yuru();
            k1.sesVer();
            k1.fareYakalama();

            Varlik v2 = k1;
            v2.yuru();
            v2.sesVer();
         //   k1 = v2; //implicit opertaor olmadan yapamayız.

          //  k1.agirlik = 10; // Ata sınıfta public olan ogeler sonuc sınıfa miras bırakılır.
                             //hem cocuk sınıfın içinden hem de cocuk sınıfın nesnesi üzerinden erişilebilirler.
         //  k1.privDegisken = 4;
                             // private olan ogeler cocuk sınıfa miras birakılmaz.
           // k1.protDegisken = 5;
           // protected olan ogeler cocuk sınıflara miras alırlar.
           //ata sınıf ve cocuk sınıf içerisinden erişilebilirler.
           //ata sınıf ve cocuk sınıf nesneleri üzerinden erişilemezler.
        }
    }
}
