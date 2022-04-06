using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var predmeti = new Dictionary<string, string>();
            predmeti.Add("RE2", "Računalni engleski jezik 2");
            predmeti.Add("FMS", "Formalne metode specifikacije");
            predmeti.Add("NUMAT", "Numerička matematika");
            predmeti.Add("OOP", "Objektno orjentirano programiranje");
            predmeti.Add("RMMU", "Racunalne mreze i mrezne usluge");
            predmeti.Add("SJWP", "Skriptni jezici i web programiranje");

            var o1 = new Dictionary<string, int>();
            o1.Add("RE2", 5);
            o1.Add("FMS", 4);
            o1.Add("NUMAT", 3);
            o1.Add("OOP", 4);
            o1.Add("RMMU", 5);
            var o2 = new Dictionary<string, int>() { { "RE2", 3 }, { "FMS", 4 }, { "NUMAT", 5 }, { "OOP", 4 }, { "RMMU", 3 } };
            var o3 = new Dictionary<string, int>() { { "RE2", 5 }, { "FMS", 2 }, { "NUMAT", 4 }, { "OOP", 3 }, { "RMMU", 4 } };
            var o4 = new Dictionary<string, int>() { { "RE2", 3 }, { "FMS", 3 }, { "NUMAT", 2 }, { "OOP", 2 }, { "RMMU", 4 } };

            var s1 = new Student("Vatroslav", "Krpan", "0195608503", o1);
            var s2 = new Student("Ivan", "Matic", "9876543210", o2);
            var s3 = new Student("Luka", "Horvat", "18700147963", o3);
            var s4 = new Student("Filip", "Ivancic", "478410963", o4);


            var listaStudenata = new List<Student>() { s1, s2, s3, s4 };
            int cntr = 1;
            string predmet;
            foreach(var s in listaStudenata)
            {
                Console.WriteLine("{0}. {1} {2} ({3})", cntr, s.Ime, s.Prezime, s.JMBAG);
                foreach(var o in s.Ocjene)
                {
                    predmeti.TryGetValue(o.Key, out predmet);
                    Console.WriteLine("{0} - {1}: {2} ",o.Key, predmet, o.Value);
                }
                cntr++;
                Console.WriteLine();
            }

            s1.NoviPredmet(predmeti, "SJWP", 0);
            s1.AzurirajOcjenu("RE2", 2);
            cntr = 1;
            foreach (var s in listaStudenata)
            {
                Console.WriteLine("{0}. {1} {2} ({3})", cntr, s.Ime, s.Prezime, s.JMBAG);
                foreach (var o in s.Ocjene)
                {
                    predmeti.TryGetValue(o.Key, out predmet);
                    Console.WriteLine("{0} - {1}: {2} ", o.Key, predmet, o.Value);
                }
                cntr++;
                Console.WriteLine();
            }
        }
    }
}
