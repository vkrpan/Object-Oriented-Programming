using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Pravokutnik : GeometrijskiLik
    {
        protected float _a, _b;
        public Pravokutnik()
        {
            _a = 0;
            _b = 0;
        }
        public Pravokutnik(string farba)
        {
            boja = farba;
        }
        public Pravokutnik(float a, float b)
        {
            _a = a;
            _b = b;
        }
        public Pravokutnik(string bo, float a, float b)
        {
            boja = bo;
            _a = a;
            _b = b;
        }
        ~Pravokutnik()
        {
            Console.WriteLine("Poziva se destruktor Pravokutnik");

        }
        public override void Tip()
        {
            Console.WriteLine("Pravokutnik sa stranicama duljine " + _a + " i " +_b);
        }
        public override float Povrsina()
        {
            return _a * _b;
        }
        public override float Opseg()
        {
            return 2 * _a + 2 * _b;
        }

    }
}
