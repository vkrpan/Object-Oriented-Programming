using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Kvadrat : Pravokutnik
    { 
        public Kvadrat()
        {
            _a = 1;
        }
        public Kvadrat(float a)
        {
            _a = a;
        }
        public Kvadrat(float a, string boja) : base(boja)
        {
            _a = a;
        }
        ~Kvadrat()
        {
            Console.WriteLine("Poziva se destruktor Kvadrat");

        }
        public override void Tip()
        {
            Console.WriteLine("Kvadrat sa stranicom duljine " + _a);
        }
        public override float Povrsina()
        {
            return _a * _a;
        }
        public override float Opseg()
        {
            return 4 * _a;
        }

    }
}
