using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ocjena
    {
        private int idPredmeta;
        private int ocijena;
        public Ocjena(int id, int ocjena)
        {
            ID = id;
            Ocjenaa = ocjena;
        }
        public int ID
        {
            get { return idPredmeta; }
            set { idPredmeta = value; }
        }
        public int Ocjenaa
        {
            get { return ocijena; }
            set { ocijena = value; }
        }
        ~Ocjena()
        {

        }
    }
}
