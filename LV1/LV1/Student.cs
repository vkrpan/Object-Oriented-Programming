using System;
using System.Collections.Generic;
using System.Text;


namespace LV1
{
    public class Student
    {
        public string ime;
        public string prezime;
        public string OIB;
        private string _JMBAG;
        public string datum_rodenja;
        public string prebivaliste;
        public string studij;
        public int godina;
        public float visina;
        public float tezina;
        public List<Predmet> predmet;
        public float prosjek;

        public Student(string i, string p, string oib, string jmbag, string date, string preb, string st, int g, float v, float t, List<Predmet> pr, float prosj)
        {
            ime = i;
            prezime = p;
            OIB = oib;
            _JMBAG = jmbag;
            datum_rodenja = date;
            prebivaliste = preb;
            studij = st;
            godina = g;
            visina = v;
            tezina = t;
            predmet = pr;
            prosjek = prosj;
        }
        ~Student()
        {

        }

        public void IspisIP()
        {
            if (ime == "" || prezime == "")
            {
                Console.WriteLine("Nedostaju podatci!");
            }
            else
            {
                Console.WriteLine(ime + " " + prezime);
            }
        }
        public string vratiJMBAG()
        {
            return _JMBAG;
        }
        public void PromjeniJMBAG(string s)
        {
            long x;
            if(s.Length == 10 && Int64.TryParse(s, out x))
            {
                _JMBAG = s;
                Console.WriteLine("Novi JMBAG je:" + s);
            }
            else
            {
                Console.WriteLine("Uneseni JMBAG ne zadovoljava kriterije!");
            }
        }
    }
}
