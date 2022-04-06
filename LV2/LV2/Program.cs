using System;
using System.Collections.Generic;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Predmet> predmeti = new List<Predmet>();
            Predmet p1 = new Predmet(1, "Osnove programiranja", 9);
            p1.Naziv = "Osnove programiranja u programskom jeziku c#";
            Console.WriteLine("Naziv predmeta objekta p1: " + p1.Naziv);

            Predmet p2 = new Predmet(2, "Objektno-orjentirano programiranje", 9);
            Predmet p3 = new Predmet(3, "Matematika", 6);
            predmeti.Add(p2);
            predmeti.Add(p3);

            List<Ocjena> ocjene1 = new List<Ocjena>();
            ocjene1.Add(new Ocjena(2, p1));
            ocjene1.Add(new Ocjena(2, p2));
            ocjene1.Add(new Ocjena(5, p3));

            List<Ocjena> ocjene2 = new List<Ocjena>();
            ocjene2.Add(new Ocjena(3, p1));
            ocjene2.Add(new Ocjena(4, p2));
            ocjene2.Add(new Ocjena(4, p3));

            List<Ocjena> ocjene3 = new List<Ocjena>();
            ocjene3.Add(new Ocjena(5, p1));
            ocjene3.Add(new Ocjena(5, p2));
            ocjene3.Add(new Ocjena(5, p3));

            List<Ocjena> ocjene4 = new List<Ocjena>();
            ocjene4.Add(new Ocjena(5, p1));
            ocjene4.Add(new Ocjena(5, p2));
            ocjene4.Add(new Ocjena(5, p3));

            List<Ocjena> ocjene5 = new List<Ocjena>();
            ocjene5.Add(new Ocjena(5, p1));
            ocjene5.Add(new Ocjena(2, p2));
            ocjene5.Add(new Ocjena(3, p3));

            List<Student> listaPrijatelja = new List<Student>();
            Student s1 = new Student("Ivan", "Ivanic", ocjene1, null);
            Student s2 = new Student("Marko", "Maric", ocjene2, null);
            Student s3 = new Student("Vatroslav", "Krpan", ocjene3, null);
            Student s4 = new Student("Roko", "Kovac", ocjene4, null);
            Student s5 = new Student("Pero", "Peric", ocjene5, null);
            listaPrijatelja.Add(s1);
            listaPrijatelja.Add(s2);
            listaPrijatelja.Add(s3);
            listaPrijatelja.Add(s4);
            listaPrijatelja.Add(s5);

            Console.WriteLine("Prosjek ocjena studenta Ivan je: "+ s1.ProsjekOcjena);
            Console.WriteLine("Prosjek ocjena studenta Marko je: " + s2.ProsjekOcjena);
            Console.WriteLine("Prosjek ocjena studenta Vatroslav je: " + s3.ProsjekOcjena);
            Console.WriteLine("Prosjek ocjena studenta Roko je: " + s4.ProsjekOcjena);
            Console.WriteLine("Prosjek ocjena studenta Pero je: " + s5.ProsjekOcjena);

            Console.WriteLine("\nStudent/i s najvecim procjekom: \n");
            foreach(var obj in s1.TopStudentPrijatelj(listaPrijatelja))
            {
                Console.WriteLine("Student:" + obj.Ime + " " + obj.Prezime + " sa prosjekom: " + obj.ProsjekOcjena);
            }


            Console.WriteLine("Student " + s1.Ime + " je prikupio " + s1.UkupnoECTS() + " ECTS bodova.");


            /*Console.WriteLine("Student:" + s1.Ime +" " + s1.Prezime + "\n");
            foreach(Ocjena o in s1.Ocjene)
            {
                Console.WriteLine(o.Predmet.Naziv + " - " + o.Iznos);
            }*/
            

        }
    }
}
