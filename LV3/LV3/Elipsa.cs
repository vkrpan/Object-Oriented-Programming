using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Elipsa : GeometrijskiLik
    {
        protected float a, b;

        public Elipsa(float vP, float mP)
        {   
            a = vP;
            b = mP;
            
        }
        public override float Povrsina()
        {
            Console.WriteLine("Povrsina elipse");
            return a * b * (float)Math.PI;
        }
        public override float Opseg()
        {
            Console.WriteLine("Opseg elipse!");
            return 0;
        }


    }
}
