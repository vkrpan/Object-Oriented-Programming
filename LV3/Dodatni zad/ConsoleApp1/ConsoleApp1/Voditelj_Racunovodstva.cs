using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Voditelj_Racunovodstva : Osoba
    {
        public Voditelj_Racunovodstva(string i, string p, string oib, string db, string zanimanje ) : base(ime, prezime, OIB, Dob, Zanimanje)
        {

        }
        private void IsplataPlace(string OIB, Osoba osoba)
        {
            int oib;
            if(int.TryParse(OIB, out oib))
            {
                if (OIB.Length == 11)
                {
                    if(osoba.GetType() == typeof(Profesor) || osoba.GetType() == typeof(Voditelj_Racunovodstva))
                    {
                        Console.WriteLine("{0} {1} ({2}) - placa isplacena.", osoba.ime, osoba.prezime, osoba._OIB);
                    }
                    else if(osoba.GetType() == typeof(Student))
                    {
                        Console.WriteLine("Student nije zaposlen!");
                    }
                    else
                    {
                        Console.WriteLine("Nepoznato zanimanje.");
                    }
                }
                else
                {
                    Console.WriteLine("OIB mora sadrzavati tocno 11 znamenaka!");
                }

            }
            else
            {
                Console.WriteLine("OIB mora biti unesen u brojcanom obliku!");
            }
        }

    }
}
