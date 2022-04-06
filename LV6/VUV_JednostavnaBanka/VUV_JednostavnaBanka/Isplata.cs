using System;
using System.Collections.Generic;
using System.Text;

namespace VUV_JednostavnaBanka
{
    class Isplata : ITransakcija2<Isplata>
    {
        public string _idTransakcije { get; private set; }
        public double _iznos { get; private set; }
        public string _poslovnica { get; private set; }
        public string _vrijeme { get; private set; }
        public string _datum { get; private set; }
        public string _brRacuna { get; private set; }
        public Isplata(string ID, double Iznos,string Poslovnica, string Vrijeme, string Datum, string brRacuna)
        {
            _idTransakcije = ID;
            _iznos = Iznos;
            _poslovnica = Poslovnica;
            _vrijeme = Vrijeme;
            _datum = Datum;
            _brRacuna = brRacuna;
        }
        public void PrikaziTransakciju()
        {
            Console.WriteLine("ID uplate: " + _idTransakcije);
            Console.WriteLine("Datum: " + _datum);
            Console.WriteLine("Broj racuna: " + _brRacuna);
            Console.WriteLine("Iznos transakcije: " + _iznos);
        }

        public void Usporedi(Isplata isplata)
        {
            throw new NotImplementedException();
        }

        public Bankar VratiBankara()
        {
            throw new NotImplementedException();
        }

        public double VratiIznos()
        {
            return _iznos;
        }

        public Klijent VratiKlijenta()
        {
            throw new NotImplementedException();
        }
    }
}
