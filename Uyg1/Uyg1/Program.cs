using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
    

            AdresDefteri defterim = new AdresDefteri();
            Raporlama rNesne = new Raporlama();
            /*  defterim.Ekle("Ali", "Güneş", "+323", "Kayseri");
              defterim.Ekle("Ahmet", "Demir", "+32-12", "Konya");
              defterim.Ekle("Mehmet", "Yılmaz", "+2323", "Ankara");
              defterim.Ekle("Ayse", "Cicek", "+3434", "İzmir");
              defterim.Ekle("Fatma", "Lale", "+232", "İstanbul");

              int indis = defterim.Bul("Ayse", "Cicek");
              Console.WriteLine(indis); */

            /*  string veri = defterim.veriUret();
              rNesne.printReport(veri);

             int sonuc = defterim.Sil("Ali", "Güneş");
              if (sonuc == -1)
                  Console.WriteLine("silinemedi");
              else
                  Console.WriteLine("silindi" + sonuc);

              veri = defterim.veriUret();
              rNesne.printReport(veri); */

            int secim = -1;

            while (secim != 0)
            {
                Console.WriteLine("1-Ekle");
                Console.WriteLine("2-Sil");
                Console.WriteLine("3-Guncelle");
                Console.WriteLine("4-Listele");
                Console.WriteLine("0-Cikis");

                Console.Write("Seciminiz: ");
                secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Ad: ");
                    string ad = Console.ReadLine();

                    Console.Write("Soyad: ");
                    string soyad = Console.ReadLine();

                    Console.Write("Tel: ");
                    string tel = Console.ReadLine();

                    Console.Write("Adres: ");
                    string adres = Console.ReadLine();

                    defterim.Ekle(ad, soyad, tel, adres);
                }

                else if (secim == 2)
                {
                    Console.Write("Ad: ");
                    string ad = Console.ReadLine();

                    Console.Write("Soyad: ");
                    string soyad = Console.ReadLine();

                    int sonuc = defterim.Sil(ad, soyad);
                    if (sonuc == -1)
                        Console.WriteLine("Kisi bulunamadi");
                    else
                        Console.WriteLine("Silindi");
                }

                else if (secim == 3)
                {
                    Console.Write("Ad: ");
                    string ad = Console.ReadLine();

                    Console.Write("Soyad: ");
                    string soyad = Console.ReadLine();

                    Console.Write("Yeni Tel: ");
                    string tel = Console.ReadLine();

                    Console.Write("Yeni Adres: ");
                    string adres = Console.ReadLine();

                    int sonuc = defterim.Guncelle(ad, soyad, tel, adres);
                    if (sonuc == -1)
                        Console.WriteLine("Kisi bulunamadi");
                    else
                        Console.WriteLine("Guncellendi");
                }

                else if (secim == 4)
                {
                    string veri = defterim.veriUret();
                    rNesne.printReport(veri);
                }
            }

        }
    }
}
