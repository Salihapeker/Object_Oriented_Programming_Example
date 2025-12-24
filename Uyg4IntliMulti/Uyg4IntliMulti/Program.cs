using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg4IntliMulti
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  ISesVerebilenler nesne = new ISesVerebilenler(); //tanımlanmaz

            Koro koromuz = new Koro();
            koromuz.sanatciEkle(new Kedi());
            koromuz.sanatciEkle(new Kopek());
            koromuz.sanatciEkle(new Insan());
            koromuz.koroSoylesin();

            DansToplulugu dt = new DansToplulugu();
            dt.dansciEkle(new Insan());
           // IDansEdebilenler d = new Insan(); bu şekilde de kullanabiliriz
            dt.dansBaslasin();
          

        }
    }
}
