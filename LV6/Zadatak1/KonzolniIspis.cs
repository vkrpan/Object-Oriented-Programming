using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak1
{
    class KonzolniIspis : Iizlaz<KonzolniIspis>
    {
        public void Ispis(string ispis)
        {
            Console.WriteLine(ispis);
        }
    }
}
