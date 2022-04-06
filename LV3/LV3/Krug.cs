using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Krug : GeometrijskiLik
    {
        private float _r;
        public Krug()
        {
            _r = 1;
        }
        public Krug(float polumjer)
        {
            _r = polumjer;
        }
        public Krug(float polumjer, string bo) : base(bo)
        {
            _r = polumjer;
        }
        ~Krug()
        {
            Console.WriteLine("Poziva se destruktor Krug");

        }
        public override void Tip()
        {
            Console.WriteLine("Krug polumjera " + _r);
        }
        public override float Povrsina()
        {
            return _r * _r * (float)(Math.PI);
        }
        public override float Opseg()
        {
            return 2 * _r * (float)Math.PI;
        }

    }
}
