using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class Predmet
    {
        private int _sifra;
        private string _naziv;
        private int _ects;

        public Predmet(int sifra, string naziv, int ects)
        {
            Sifra = sifra;
            Naziv = naziv;
            Ects = ects;
            
        }
        public int Sifra
        {
            get { return _sifra; }
            set { _sifra = value; }
        }
        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }
        public int Ects
        {
            get { return _ects; }
            set { _ects = value; }
        }
    }
}
