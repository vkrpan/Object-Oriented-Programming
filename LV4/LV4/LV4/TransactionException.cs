using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class TransactionException : Exception
    {
        public TransactionException(string message) : base(message)
        {
            Console.WriteLine("Iznimka uhvacena");
        }
    }
}
