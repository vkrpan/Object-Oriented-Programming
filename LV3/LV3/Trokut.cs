using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Trokut : GeometrijskiLik
    {
        protected float _a, _b, _c;
        public Trokut()
        {
            _a = _b = _c = 0;
        }
        public Trokut(string farba)
        {
            boja = farba;
        }
        public Trokut(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public Trokut(string bo, float a, float b, float c)
        {
            boja = bo;
            _a = a;
            _b = b;
            _c = c;
        }
        protected virtual bool isValid()
        {
            if (_a <= 0 || _b <= 0 || _c <= 0)
                return false; // problem sa duljinama stranica
            else if ((_a + _b) < _c || (_a + _c) < _b || (_b + _a) < _a)
                return false; // ne vrijedi nejednakost trokuta
            else return true;
        }
        public override void Tip()
        {
            Console.WriteLine("Trokut sa stranicama duljine " + _a + ", " + _b
           + " i " + _c);
        }
        ~Trokut()
        {
            Console.WriteLine("Poziva se destruktor Trokut");

        }
        public override float Povrsina()
        {
            if (isValid())
            {
                // Heronova formula
                float s = (_a + _b + _c) / 2;
                float P = (float)Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
                return P;
            }
            else
            {
                // Trokut nije dobro definiran.
                return -1;
            }
        }
        public override float Opseg()
        {
            if (isValid())
            {
                return _a + _b + _c;
            }
            else
            {
                // Trokut nije dobro definiran.
                return -1;
            }
        }
    }
    
    //////////////////////////////////////////////
    
    class JednakostranicniTrokut : Trokut
    {
        public JednakostranicniTrokut(float a)
        {
            _a = a;
        }
        public JednakostranicniTrokut(float a, string boja) : base(boja)
        {
            _a = a;
        }
        ~JednakostranicniTrokut()
        {
            Console.WriteLine("Poziva se destruktor JednakostranicniTrokut");
        }
        public override void Tip()
        {
            Console.WriteLine("Jednakostranicni trokut sa stranicom duljine " +
           _a);
        }
        public override float Povrsina()
        {
            return (float)(Math.Sqrt(3) / 4) * _a * _a;
        }
        public override float Opseg()
        {
            return 3 * _a;
        }
    }

    ////////////////////////////////////////////////////
    class PravokutniTrokut : Trokut
    {
        public PravokutniTrokut(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public PravokutniTrokut(float a, float b, float c, string farba)
        {
            _a = a;
            _b = b;
            _c = c;
            boja = farba;
        }
        ~PravokutniTrokut()
        {
            Console.WriteLine("Poziva se destruktor PravokutniTrokut");

        }
        protected override bool isValid()
        {
            if (_a <= 0 || _b <= 0 || _c <= 0)
                return false;
            else if ((_a + _b) < _c || (_a + _c) < _b || (_b + _a) < _a)
                return false;
            else if (_a * _a + _b * _b != _c * _c) // Pitagorin poucak
                return false;
            else return true;
        }
        public override void Tip()
        {
            Console.WriteLine("Pravokutni trokut sa stranicama duljine " + _a +
           ", " + _b + " i " + _c);
        }
        public override float Povrsina()
        {
            if (isValid())
                return _a * _b / 2;
            else
                return -1;
        }
    }
    class JednakokracanTrokut : Trokut
    {
        protected override bool isValid()
        {
            if (_a <= 0 || _b <= 0)
                return false;
            else return true;
        }
        private float Visina()
        {
            if (isValid())
            {
                if(_a == _b)
                    return 
            }

        }
    }
}