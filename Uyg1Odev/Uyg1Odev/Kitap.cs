using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Odev
{
    internal class Kitap
    {
        public string kitapAdi;
        public string yazar;
       static  int oduncKitapSayisi = 0;
        public void OduncVer()
        {
           // Console.WriteLine(yazar + " tarafından yazilan " + kitapAdi + " isimli kitap odunc verildi " );
           oduncKitapSayisi++;
            Console.WriteLine("odunc kitap sayisi = " + oduncKitapSayisi);
        }
    }
}
//static üyeler (metodlar veya degiskenler) nesne ismi üzerinden erişilemezler. bir tip ismi üzerinden erişebilirsin
//cannot be accessed with an instance reference, qualify it with a type name instead


// static üyeler nesnleri bireysel olarak değil sınıfın geneli ilgilendirir.
// sınıf ismi üzerinden çağrılırlar.
//statik metodların içerisinde nonstatik değişken kullanılamaz, sadece statik değişken kullanılabilir.
//nonstatic metodlar hem static hem de nonstatic değişkenleri kullanabilirler. 


