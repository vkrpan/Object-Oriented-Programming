using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Kolegij
    {
        private int _ID;
        private string _naziv;
        private int _ECTS;
        private int _brojSatiRada;
        private int _bodoviIspit;
        public Kolegij(int id, string naziv, int ects, int brSatirada, int bodoviIspit)
        {
            id = ID;
            naziv = Naziv;
            ects = ECTS;
            brSatirada = BrojSatirada;
            bodoviIspit = BodoviIspit;
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }
        public int ECTS
        {
            get { return _ECTS; }
            set { _ECTS = value; }
        }
        public int BrojSatirada
        {
            get { return _brojSatiRada; }
            set { _brojSatiRada = value; }
        }
        public int BodoviIspit
        {
            get { return _bodoviIspit; }
            set { _bodoviIspit = value; }
        }
    }
}
