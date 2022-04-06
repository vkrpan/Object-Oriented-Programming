using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class Isplata : ITransakcija, IUsporedba<Isplata>
    {
       
        private string _id;
        private string _datum;
        private string _korisnik;
        private double _iznos;

        public Isplata(string id, string datum, string korisnik, double iznos)
        {
            _id = id;
            _datum = datum;
            _korisnik = korisnik;

        }
        public void PrikaziTransakciju()
        {

        }
        public double VratiIznos()
        {
            return _iznos;
        }
        public bool jednako(Isplata isplata)
        {
            if(_korisnik == isplata._korisnik && _iznos == isplata._iznos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
