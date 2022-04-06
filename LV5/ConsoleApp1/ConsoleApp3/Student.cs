using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student
    {
        private string _ime;
        private string _prezime;
        private string _jmbag;
        private SortedList<string, int> _ocjene;
        public Student(string ime, string prezime, string jmbag, SortedList<string, int> ocjene)
        {
            _ime = ime;
            _prezime = prezime;
            _jmbag = jmbag;
            _ocjene = ocjene;
            /*try
            {
                if(Convert.ToInt32(ocjene.Values) < 0 || Convert.ToInt32(ocjene.Values) > 5)
                {
                    throw new Exception("Ocjena ne moze biti manja od 0 ili veca od 5!");
                }
                else
                {
                    _ocjene = ocjene;
                }
            }
            catch
            {
                Console.WriteLine("Neispravno unesena ocjena sada iznosi 0");
            }*/
        }

        public string Ime
        {
            get { return _ime; }
        }
        public string Prezime
        {
            get { return _prezime; }
        }
        public string JMBAG
        {
            get { return _jmbag; }
        }
        public SortedList<string, int> Ocjene
        {
            get { return _ocjene; }
        }

        public void AzurirajOcjenu(string ID_predmeta, int ocjena)
        {
            if (Ocjene.ContainsKey(ID_predmeta))
            {
                Ocjene[ID_predmeta] = ocjena;
            }
            else
            {
                Console.WriteLine("{0} {1} sa JMBAG-om:{2} nema upisan predmet sa kljucem {3}", Ime, Prezime, JMBAG, ID_predmeta);
            }
        }
        public void NoviPredmet(SortedList<string, string> predmeti, string ID_predmeta, int ocjena)
        {
            if (Ocjene.ContainsKey(ID_predmeta))
            {
                Console.WriteLine("Predmet {0} je već upisan i ne može se upisati!\n", Ocjene[ID_predmeta]);
            }
            else if (predmeti.ContainsKey(ID_predmeta))
            {
                Ocjene.Add(ID_predmeta, ocjena);
                Console.WriteLine("Predmet {0} sa ocijenom {1} je uspješno dodan!\n", ID_predmeta, ocjena);
            }
            else
            {
                Console.WriteLine("Predmet sa kljucem {0} ne postoji!\n", ID_predmeta);
            }
        }
    }
}
