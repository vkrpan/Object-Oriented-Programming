using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Projekt
    {
        private int _id;
        private string _naziv;
        private int _satiRada;
        public Projekt(int id, string naziv, int satiRada)
        {
            id = ID;
            naziv = Naziv;
            satiRada = SatiRada;
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }
        public int SatiRada
        {
            get { return _satiRada; }
            set { _satiRada = value; }
        }
    }
}
