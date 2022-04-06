using System;
using System.Collections.Generic;
using System.Linq;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string newJMBAG = "0123456789";
            List<string> predmeti = new List<string>() { "OOP", "NUM", "ENGL", "RMMU", "FMS" };
            List<int> ocjene = new List<int>() {2,3,4,5,5};
            Student x1 = new Student("Vatroslav", "Krpan", "12345679", "01650983", "21.02.2001", "Belišće", "Racunarstvo", 1, 183, 80, predmeti, ocjene);
            x1.IspisIP();
            x1.IspisiPredmete();
            x1.ProsjekOcjena();
            x1.PromjeniJMBAG(newJMBAG);*/
            Predmet x1 = new Predmet(1, "Matematika", "Spoljaric", 6, 4);
            Predmet x2 = new Predmet(2, "Engleski", "Kovac", 6, 2);
            Predmet x3 = new Predmet(3, "Fizika", "Jukic", 6, 5);
            List<Predmet> predmeti_prvi = new List<Predmet>() { x1, x2, x3 };
            Predmet x4 = new Predmet(4, "Racunalne Mreze", "Cirikovic", 8, 5);
            Predmet x5 = new Predmet(5, "ICT", "Hasija", 2, 2);
            Predmet x6 = new Predmet(2, "Engleski", "kovac", 6, 5);
            List<Predmet> predmeti_drugi = new List<Predmet>() { x4, x5, x6 };
            Predmet x7 = new Predmet(1, "Matematika", "Spoljaric", 6, 2);
            Predmet x8 = new Predmet(3, "Fizika", "Jukic", 6, 2);
            Predmet x9 = new Predmet(5, "ICT", "Hasija", 6, 3);
            List<Predmet> predmeti_treci = new List<Predmet>() { x7, x8, x9 };
            Predmet x10 = new Predmet(2, "Engleski", "Kovac", 6, 4);
            Predmet x11 = new Predmet(1, "Matematika", "Spoljaric", 6, 5);
            Predmet x12 = new Predmet(4, "Racunalne Mreze", "Cirikovic", 8, 5);
            List<Predmet> predmeti_cetvrti = new List<Predmet>() { x10, x11, x12 };
            Predmet x13 = new Predmet(4, "Racunalne Mreze", "Cirikovic", 8, 2);
            Predmet x14 = new Predmet(1, "Matematika", "Spoljaric", 6, 5);
            Predmet x15 = new Predmet(3, "Fizika", "Jukic", 6, 2);
            List<Predmet> predmeti_peti = new List<Predmet>() { x13, x14, x15 };

            Student prvi = new Student("Vatroslav", "Krpan", "12345679", "01650983", "21.02.2001", "Belišće", "Racunarstvo", 1, 183, 80, predmeti_prvi,0);
            Student drugi = new Student("Bruno", "Benja", "9876543210", "01652088", "18.06.2000", "Ilok", "Racunarstvo", 2, 174, 70, predmeti_drugi,0);
            Student treci = new Student("Ivan", "Loina", "9638527410", "01672283", "30.08.2000", "Virovitica", "Racunarstvo", 1, 190, 85, predmeti_treci,0);
            Student cetvrti = new Student("Luka", "Horvat", "7418529630", "02236749", "02.03.1998", "Osijek", "Racunarstvo", 3, 185, 83, predmeti_cetvrti,0);
            Student peti = new Student("Juraj", "Jurcevic", "6874522019", "01150983", "25.12.1995", "Ivanovci", "Racunarstvo", 4, 172, 68, predmeti_peti,0);
            List<Student> studenti = new List<Student>() { prvi, drugi, treci, cetvrti, peti };

            int cntr = 1;
            foreach (Student obj in studenti)
            {
                
                Console.WriteLine(cntr+ ". Student: "+ obj.ime + " "+obj.prezime);
                Console.WriteLine("OIB: {0} \nJMBAG: {1}\nPrebivaliste: {2}\nStudij i godina: {3}, {4}. godina", obj.OIB, obj.vratiJMBAG(), obj.prebivaliste, obj.studij, obj.godina);
                foreach (Predmet obj2 in obj.predmet)
                {
                    if (obj2.ocjena == 1)
                    {
                        Console.WriteLine(obj2.naziv + " - Predmet nije položen!");
                    }
                    else
                    {
                        Console.WriteLine(obj2.naziv + " - " + obj2.ocjena);

                    }
                }
                Console.WriteLine("\n");
                cntr++;
            }
            sortirajListu(studenti);
        }
        static List<Student> sortirajListu(List<Student> studentS)
        {
            float prosjek, sum = 0;
            foreach(Student student in studentS)
            {
                prosjek = 0;
                sum = 0;
                int cntr = 0;
                int ects = 0;
                foreach (Predmet predmet in student.predmet)
                {
                    cntr += 1;
                    sum += predmet.ocjena;
                    ects += predmet.ECTS;
                }
                student.prosjek = sum / cntr;
            }
            var sortirana = studentS.OrderByDescending(x => x.prosjek).ToList();

            foreach(var obj in sortirana)
            {
                Console.WriteLine("Student: " + obj.ime + " " + obj.prezime + " - Prosjek:" + obj.prosjek);
            }
            return sortirana;

        }
    }
}
