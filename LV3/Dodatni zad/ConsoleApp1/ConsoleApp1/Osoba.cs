using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Osoba
    {
        public string ime;
        public string prezime;
        public int _OIB;
        public int dob;
        public string zanimanje;
        public Osoba(string Ime, string Prezime, int OIB, int Dob, string Zanimanje)
        {
            ime = Ime;
            prezime = Prezime;
            _OIB = OIB;
            dob = Dob;
            zanimanje = Zanimanje;
        }

        public void jedi(List<string> hrana)
        {
            foreach(var o in hrana)
            {
                Console.WriteLine("Osoba " + ime + " " + prezime+" je pojela:" + o);
            }
        }
    }
}
