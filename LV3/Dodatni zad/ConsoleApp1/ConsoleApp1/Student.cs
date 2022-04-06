using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student : Osoba
    {
        protected List<Kolegij> _upisaniKolegiji;
        protected List<Ocjena> _ocjene;
        public string Spol;
        public Student(List<Kolegij> upisaniKolegiji, List<Ocjena> ocjene, string spol)
        {
            _upisaniKolegiji = upisaniKolegiji;
            _ocjene = ocjene;
            Spol = spol;
        }
        public List<Kolegij> UpisaniKolgiji
        {
            get { return _upisaniKolegiji; }
            set { _upisaniKolegiji = value; }
        }
        ~Student()
        {

        }
    }
}
