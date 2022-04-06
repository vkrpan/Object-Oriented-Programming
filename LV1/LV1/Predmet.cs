using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    public class Predmet
    {
        private int ID;
        public string naziv;
        public string nositelj;
        public int ECTS;
        public int ocjena;

        public Predmet(int id, string Naziv, string Nositelj, int ects, int ocj)
        {
            ID = id;
            naziv = Naziv;
            nositelj = Nositelj;
            ECTS = ects;
            ocjena = ocj;
        }
        ~Predmet()
        {

        }

    }
}
