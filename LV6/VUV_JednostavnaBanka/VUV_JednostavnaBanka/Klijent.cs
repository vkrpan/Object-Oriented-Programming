using System;
using System.Collections.Generic;
using System.Text;

namespace VUV_JednostavnaBanka
{
    class Klijent : Osoba
    {
        public string idKlijenta { get; private set; }
        public string _OIB { get; private set; }
        public Klijent(string Ime, string Prezime, string datRod, string Spol,string OIB, string IDKlijenta)
        {
            ime = Ime;
            prezime = Prezime;
            datRodenja = datRod;
            spol = Spol;
            idKlijenta = IDKlijenta;
            _OIB = OIB;
        } 
    }
}
