using System;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Uplata u1 = new Uplata("001", "18.04", "Korisnik1", 584.36);
            Uplata u2 = new Uplata("002", "18.04", "Korisnik1", 584.36);
            Uplata u3 = new Uplata("003", "18.04", "Korisnik2", 558744);
            ITransakcija u4 = new Uplata("004", "18.04", "Ivo", 874.587);
            bool ispravan = false;
            Uplata u5 = new Uplata("", "", "", 0);
            Console.WriteLine("Unesite id ");
            u5.ID = Console.ReadLine();
            Console.WriteLine("Unesite datum ");
            u5.Datum = Console.ReadLine();
            Console.WriteLine("Unesite ime korisnika ");
            u5.Korisnik = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Unesite iznos transakcije ");
                    u5.Iznos = Convert.ToDouble(Console.ReadLine());
                    if (u5.Iznos < 0)
                    {
                        throw new TransactionException("Iznos je 0 ili manji od 0");
                    }
                    else
                    {
                        ispravan = true;
                    }

                }
                catch (TransactionException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!ispravan);
        }
    }
}
