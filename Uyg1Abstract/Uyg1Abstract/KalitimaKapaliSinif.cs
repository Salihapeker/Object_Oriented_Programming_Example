using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1Abstract
{
    sealed class KalitimaKapaliSinif: KatButonu
    {
        public void deneme()
        {
            Console.WriteLine("deneme");
        }//deneme
    }//class

    class BirSinif //: KalitimaKapaliSinif  
    {

    }

    //kalıtıma kapatmak istediğimiz bir sinifin başına sealed koyarak kapatabiliriz.
    //başka bir sınıftan miras alabilir ancak başka bir sınıfa miras bırakılmaz.
    //sealed classlardan nesne türetebiliriz.
}
