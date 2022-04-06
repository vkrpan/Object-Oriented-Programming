using System;
using System.Collections.Generic;
using System.Text;

namespace VUV_JednostavnaBanka
{
    class Racun
    {
        public string _idKlijenta { get; private set; }
        public string _idBankara { get; private set; }
        public string _brRacuna { get; private set; }
        public string _vrstaRacuna { get; private set; }
        public string _datum { get; private set; }
        public string _vrijeme { get; private set; }
        public string _poslovnica { get; private set; }
        public double _saldo { get; private set; }
        public List<ITransakcija2<Uplata>> listaUplata;
        public List<ITransakcija2<Isplata>> listaIsplata;
        public Racun(string idKlijenta, string idBankara, string brRacuna, string vrstaRacuna, string datum, string vrijeme, string poslovnica)
        {
            _idKlijenta = idKlijenta;
            _idBankara = idBankara;
            _brRacuna = brRacuna;
            _vrstaRacuna = vrstaRacuna;
            _datum = datum;
            _vrijeme = vrijeme;
            _poslovnica = poslovnica;
            //_saldo = Saldo;
        }

    }
}
