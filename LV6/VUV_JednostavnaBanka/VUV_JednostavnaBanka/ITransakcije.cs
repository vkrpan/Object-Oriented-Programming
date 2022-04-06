using System;
using System.Collections.Generic;
using System.Text;

namespace VUV_JednostavnaBanka
{
    interface ITransakcije
    {
        string _idTransakcije { get; }
        double _iznos { get; }
        string _poslovnica { get; }
        string _datum { get; }
        string _vrijeme { get; }
        string _brRacuna { get; }

        void PrikaziTransakciju();
        Klijent VratiKlijenta();
        Bankar VratiBankara();
        double VratiIznos();
    }
}
