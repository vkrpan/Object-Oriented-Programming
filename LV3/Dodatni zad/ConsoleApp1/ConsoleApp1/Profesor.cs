using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Profesor : Osoba
    {
        private List<Kolegij> _kolegiji { get; set; }
        private List<Student> _popisStudenata { get; set; }
        public string titula { get; set; }
        public string obrazovnaUstanova { get; set; }
        public Profesor(List <Kolegij> kolegiji, List<Student> popisStudenata, string Titula, string ObrazovnaUstanova)
        {
            _kolegiji = kolegiji;
            _popisStudenata = popisStudenata;
            titula = Titula;
            obrazovnaUstanova = ObrazovnaUstanova;

        }

        private void UrediMaterijale(string IDkolegija)
        {
            int id;
            if(Int32.TryParse(IDkolegija, out id))
            {
                foreach (Kolegij predmet in _kolegiji)
                {
                    if (id == predmet.ID)
                    {
                        Console.WriteLine("Materijali kolegija" + predmet.Naziv + " su uredni.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Funkciji nije prosljeden id kolegija!");
            }
        }
        private void OdrziPredavanja(string IDkolegija, int brSati)
        {
            bool xyz = false;
            foreach(Kolegij predmet in _kolegiji)
            {
                if(Convert.ToInt32(IDkolegija) == predmet.ID && brSati < 6)
                {
                    xyz = true;
                    Console.WriteLine("Profesor " + ime + " " + prezime + " održao je danas " + brSati + " sati predavanja iz predmeta " + predmet.Naziv);
                }
            }
            if (xyz == false)
            {
                Console.WriteLine("Predavanje se ne moze odrzati!");
            }
        }
        private void Ispraviispite(List<Student> studenti, string kolegij)
        {
            Random rnd = new Random();
            foreach(Student obj in studenti)
            {
                foreach(Kolegij predmet in obj.UpisaniKolgiji)
                {
                    if(predmet.Naziv == kolegij)
                    {
                        predmet.BodoviIspit = rnd.Next(0, 100);
                    }
                }
            }
        }
    }
}
