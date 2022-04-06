using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class Ocjena
    {
        private int _iznos;
        private Predmet _predmet;

        public Ocjena(int iznos, Predmet predmet)
        {
            Iznos = iznos;
            Predmet = predmet;

        }
        public int Iznos
        {
            get { return _iznos; }
            set { _iznos = value; }
        }
        public Predmet Predmet
        {
            get { return _predmet; }
            set { _predmet = value; }
        }
    }
}
