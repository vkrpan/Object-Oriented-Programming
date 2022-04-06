using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class Uplata : ITransakcija, IUsporedba<Uplata>
    {
        private string _id;
        private string _datum; 
        private string _korisnik;
        private double _iznos;
        public Uplata()
        {

        }

        public Uplata(string id, string datum, string korisnik, double iznos)
        {
            ID = id;
            Datum = datum;
            Korisnik = korisnik;
            Iznos = iznos;
        }
        public void PrikaziTransakciju()
        {
            Console.WriteLine("ID uplate: " + _id);
            Console.WriteLine("Datum: "+_datum);
            Console.WriteLine("Korisnik: "+_korisnik);
            Console.WriteLine("Iznos transakcije: "+_iznos);
        }

        public double VratiIznos()
        {
            return _iznos;
        }
        public bool jednako(Uplata uplata)
        {
            
            if(_korisnik == uplata._korisnik && _iznos==uplata._iznos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ID
        {
            set { _id = value; }
        }
        public string Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }
        public string Korisnik
        {
            get { return _korisnik; }
            set { _korisnik = value; }
        }
        public double Iznos
        {
            get { return _iznos; }
            set { _iznos = value; }
        }

    }
}
