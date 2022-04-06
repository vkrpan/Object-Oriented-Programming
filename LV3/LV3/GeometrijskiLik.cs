using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class GeometrijskiLik
    {
        public string boja;
        public int cntr_obj = 0;
        public GeometrijskiLik()
        {
            boja = "Zelena";
            cntr_obj += 1;
        }
        public virtual void Tip()
        {
            Console.WriteLine("Geometrijski lik.");
        }
        public GeometrijskiLik(string b)
        {
            cntr_obj += 1;
            boja = b;
        }
        ~GeometrijskiLik()
        {
            Console.WriteLine("Poziva se destruktor GeometrijskiLik");
        }
        public virtual float Povrsina()
        {
            Console.WriteLine("Povrsina geometrijskog lika.");
            return 0;
        }
        public virtual float Opseg()
        {
            Console.WriteLine("Opseg geometrijskog lika.");
            return 0;
        }

    }
}
