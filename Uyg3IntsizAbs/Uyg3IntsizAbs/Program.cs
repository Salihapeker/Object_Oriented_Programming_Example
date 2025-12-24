using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3IntsizAbs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koro koromuz = new Koro();
            Kedi k1 = new Kedi();
            koromuz.sanatciEkle(k1);
            koromuz.sanatciEkle(new Kedi());
            koromuz.sanatciEkle(new Kopek());
            koromuz.sanatciEkle(new Kopek());
            koromuz.sanatciEkle(new Insan());

            koromuz.koroSoylesin();

            DansToplulugu dt = new DansToplulugu();
            dt.dansciEkle(new Robot());

            dt.dansBaslasin();
        }
    }
}
