using System;
using System.IO;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                KonzolniIspis x = new KonzolniIspis();
                x.Ispis("Testiramo ispisa u konzolu!");
                using FileStream y = new FileStream("toktokova.txt", FileMode.Create, FileAccess.Write);
                DatotekaIspis tok = new DatotekaIspis(y);
                tok.Ispis("Testiramo ispis u datoteku!");
                tok.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
