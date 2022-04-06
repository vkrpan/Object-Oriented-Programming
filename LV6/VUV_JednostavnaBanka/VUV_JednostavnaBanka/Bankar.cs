using System;
using System.Collections.Generic;
using System.Text;

namespace VUV_JednostavnaBanka
{
    class Bankar : Osoba
    {
        public string idBankara { get;  private set; }
        public Bankar(string Ime, string Prezime, string datRod ,string Spol, string IDBankara)
        {
            ime = Ime;
            prezime = Prezime;
            datRodenja = datRod;
            spol = Spol;
            idBankara = IDBankara;
        }

    }
}
