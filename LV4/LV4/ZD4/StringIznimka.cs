using System;
using System.Collections.Generic;
using System.Text;

namespace ZD4
{
    class StringIznimka : FormatException
    {
        public StringIznimka(string message) : base(message)
        {
            Console.WriteLine("Iznima uhvacena!");
        }
    }
}
