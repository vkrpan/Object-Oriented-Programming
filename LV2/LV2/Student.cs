using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class Student
    {
        private string _ime;
        private string _prezime;
        private float _prosjek_ocjena;
        private List<Ocjena> _ocjene;
        private List<Student> _prijatelj;

        public Student(string ime, string prezime, List<Ocjena> ocjene, List<Student> prijatelj)
        {
            Ime = ime;
            Prezime = prezime;
            Ocjene = ocjene;
            Prijatelj = prijatelj;
            int sum = 0;
            foreach(Ocjena o in Ocjene)
            {
                sum += o.Iznos;
            }
            if (sum > 0)
            {
                ProsjekOcjena = (float)sum / Ocjene.Count;
            }
            else
            {
                ProsjekOcjena = 0f;
            }

        }
        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }
        public string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }
        public float ProsjekOcjena
        {
            get { return _prosjek_ocjena; }
            set { _prosjek_ocjena = value; }
        }
        public List<Ocjena> Ocjene
        {
            get { return _ocjene; }
            set { _ocjene = value; }
        }
        public List<Student> Prijatelj
        {
            get { return _prijatelj; }
            set { _prijatelj = value; }
        }

        public List<Student> TopStudentPrijatelj(List<Student> prijatelji)
        {
            int sum = 0;
            foreach(Student stud in prijatelji) //---------------------------------------------
            {
                foreach(Ocjena o in stud.Ocjene)
                {
                    sum += o.Iznos;             //        racuna prosjeke i sprema ih
                }
                ProsjekOcjena = (float)sum / Ocjene.Count;
                sum = 0;
            }                                  //-----------------------------------------------
            float max = 0;                     //-----------------------------------------------
            foreach(Student stud in prijatelji)
            {
                if(stud.ProsjekOcjena> max)
                {
                    max = stud.ProsjekOcjena;  //           trazi najveci prosjek ocj i sprema ga u max
                }
                else
                {
                    continue;
                }
            }                                   //-----------------------------------------------
            int cntr = 0;
            List<Student> vrati = new List<Student>();
            foreach (Student stud in prijatelji)  //-------------------------------------------
            {
                if (stud.ProsjekOcjena == max)
                {
                    cntr += 1;
                }                                  //  prebrojava koliko studenata ima isti(max) prosjek
                else
                {
                    continue;
                }
            }                                      //-----------------------------------------------
            foreach (Student stud in prijatelji)   //-----------------------------------------------
            {
                if(cntr == 1 && stud.ProsjekOcjena == max)
                {
                    vrati.Add(stud);              //       slučaj kad jedna osoba ima najveci prosjek
                    return vrati;
                }                                //-----------------------------------------------
                else if (cntr > 1)                             //-----------------------------------------------
                {
                    foreach(Student stud2 in prijatelji)
                    {
                        if (stud2.ProsjekOcjena == max)
                        {
                            vrati.Add(stud2);                //       slučaj kad vise osoba ima isti(max) prosjek
                        }
                        else
                        {
                            continue;
                        }
                    }
                    return vrati;
                }                                            //-----------------------------------------------
                else
                {
                    continue;
                }
            }
            return null;
        }
        public int UkupnoECTS()
        {
            int ukupno = 0;
            foreach(Ocjena o in Ocjene)
            {
                if (o.Iznos > 1)
                {
                    ukupno += o.Predmet.Ects;
                }
                else
                {
                    continue;
                }
            }
            return ukupno;
        }
    }
}
