using System;
using System.Collections.Generic;

namespace LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometrijskiLik t1 = new Trokut("Plava", 2, 3, 30);
            GeometrijskiLik t2 = new JednakostranicniTrokut(2);
            GeometrijskiLik t3 = new PravokutniTrokut(3, 4, 6);
            GeometrijskiLik k1 = new Krug(); // _r = 1 zbog konstruktora
            GeometrijskiLik k2 = new Krug((float)3.4);
            GeometrijskiLik p1 = new Pravokutnik("Crvena", (float)2.5, 4);
            GeometrijskiLik kv1 = new Kvadrat(); // boja="Zuta", a=5
            GeometrijskiLik kv2 = new Kvadrat(); // _a = 1 zbog konstruktora
            Console.WriteLine("Lista geometrijskih likova:");

            GeometrijskiLik g1 = new Krug((float)2.5);
            GeometrijskiLik g2 = new Trokut("Crvena", 7, 4,2);
            GeometrijskiLik g3 = new JednakostranicniTrokut(10);
            GeometrijskiLik g4 = new Pravokutnik("Plava", 5, 6);
            GeometrijskiLik g5 = new Kvadrat(5, "Crna");
            GeometrijskiLik g6 = new PravokutniTrokut(2, 4, 6, "Siva");
            GeometrijskiLik g7 = new Krug((float)3.14, "Zelena");

            List<GeometrijskiLik> listaLikova = new List<GeometrijskiLik>();
            listaLikova.Add(g1);
            listaLikova.Add(g2);
            listaLikova.Add(g3);
            listaLikova.Add(g4);
            listaLikova.Add(g5);
            listaLikova.Add(g6);
            listaLikova.Add(g7);
            List<GeometrijskiLik> geom_likovi = new List<GeometrijskiLik>() {t1,t2, t3, k1, k2, p1, kv1, kv2 };
            foreach (GeometrijskiLik g in geom_likovi)
            {
                g.Tip();
                if (g.Opseg() <= 0 || g.Povrsina() <= 0)
                {
                    Console.WriteLine("Geometrijski lik nije dobro definiran!");
                    Console.WriteLine("Boja: " + g.boja);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Opseg: " + g.Opseg());
                    Console.WriteLine("Povrsina: " + g.Povrsina());
                    Console.WriteLine("Boja: " + g.boja);
                    Console.WriteLine();
                }
            }
            Elipsa e1 = new Elipsa(1, 2);
            Elipsa e2 = new Elipsa(5, 8);
        }

    }
    }
