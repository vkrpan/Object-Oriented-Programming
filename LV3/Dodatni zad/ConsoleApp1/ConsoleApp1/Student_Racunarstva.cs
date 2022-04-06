using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student_Racunarstva : Student
    {
        public List<string> _programskiJezici;
        public List<Projekt> _projekti;

        public Student_Racunarstva(List<Kolegij> upisaniKolegiji, List<Ocjena> ocjene, string spol, List<string> programskiJezici, List<Projekt> projekti) : base(upisaniKolegiji, ocjene, spol)
        {
            _programskiJezici = programskiJezici;
            _projekti = projekti;
        }

        private void ProuciMaterijale(string IDkolegija, int satiUcenja)
        {
            bool xyz = false;
            foreach(Kolegij predmet in _upisaniKolegiji)
            {
                if(Convert.ToInt32(IDkolegija) == predmet.ID && satiUcenja < 20)
                {
                    predmet.BrojSatirada += satiUcenja;
                    xyz = true;
                }
            }
            if (!xyz && satiUcenja > 20)
            {
                Console.WriteLine("Uneseno vise od 20 sati ucenja sto nije moguce!");
            }
            else
            {
                Console.WriteLine("Kolegij nije pronađen!");
            }
        }
        private void zavrseniProjekt(string IDprojekta, string nazivProjekta, int brSati)
        {
            Projekt p = new Projekt(Convert.ToInt32(IDprojekta), nazivProjekta, brSati);
            _projekti.Add(p);
            Console.WriteLine("Projekt je stvoren i dodan u listu projekata!");
        }
        ~Student_Racunarstva()
        {

        }
    }
}
