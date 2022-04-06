using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolegij k1 = new Kolegij(1, "Matematika", 6, 15, 56);
            Kolegij k2 = new Kolegij(2, "Algoritmi", 6, 12, 68);
            Kolegij k3 = new Kolegij(3, "Engleski", 3, 10, 78);
            List<Kolegij> predmeti = new List<Kolegij>();
            predmeti.Add(k1);
            predmeti.Add(k2);
            predmeti.Add(k3);
            List<Ocjena> ocjene1= new List<Ocjena>();
            ocjene1.Add(new Ocjena(1, 5));
            ocjene1.Add(new Ocjena(2, 2));
            ocjene1.Add(new Ocjena(3, 4));
            List<Ocjena> ocjene2 = new List<Ocjena>();
            ocjene2.Add(new Ocjena(1, 2));
            ocjene2.Add(new Ocjena(2, 5));
            ocjene2.Add(new Ocjena(3, 5));
            List<Ocjena> ocjene3 = new List<Ocjena>();
            ocjene3.Add(new Ocjena(1, 5));
            ocjene3.Add(new Ocjena(2, 5));
            ocjene3.Add(new Ocjena(3, 3));
            List<Ocjena> ocjene4 = new List<Ocjena>();
            ocjene4.Add(new Ocjena(1, 2));
            ocjene4.Add(new Ocjena(2, 2));
            ocjene4.Add(new Ocjena(3, 3));
            List<Ocjena> ocjene5 = new List<Ocjena>();
            ocjene5.Add(new Ocjena(1, 4));
            ocjene5.Add(new Ocjena(2, 4));
            ocjene5.Add(new Ocjena(3, 5));
            Student s1 = new Student(predmeti, ocjene1, "M");
            Student s2 = new Student(predmeti, ocjene2, "F");
            List<string> programskiJezici = new List<string>();
            programskiJezici.Add("C#");
            programskiJezici.Add("C++");
            programskiJezici.Add("JS");
            List<Projekt> projekti1 = new List<Projekt>();
            Projekt p1 = new Projekt(1, "HNL", 380);
            Projekt p2 = new Projekt(2, "Milijunas", 2250);
            projekti1.Add(p1);
            projekti1.Add(p2);
            List<Projekt> projekti2 = new List<Projekt>();
            projekti2.Add(new Projekt(3, "Auto-kuca", 480));
            projekti2.Add(new Projekt(4, "Simulacija utakmice", 220));
            Student s3 = new Student_Racunarstva(predmeti, ocjene3, "M", programskiJezici, projekti1);
            Student s4 = new Student_Racunarstva(predmeti, ocjene4, "M", programskiJezici, projekti2);
            Student s5 = new Student_Racunarstva(predmeti, ocjene5, "F", programskiJezici, projekti1);
            List<Student> studenti = new List<Student>();
            studenti.Add(s1);
            studenti.Add(s2);
            studenti.Add(s3);
            studenti.Add(s4);
            studenti.Add(s5);
            Profesor prof1 = new Profesor(predmeti, studenti, "Dr.", "VUV");
            Voditelj_Racunovodstva v1 = new Voditelj_Racunovodstva()

        }
    }
}
