using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zadatak1
{
    class DatotekaIspis :Iizlaz<DatotekaIspis>
    {
        private FileStream _tok;
        private StreamWriter _sw;
        public DatotekaIspis(FileStream tok)
        {
            _tok = tok;
            _sw = new StreamWriter(tok);
        }
        public void Ispis(string tekst)
        {
            _sw.WriteLine(tekst);
        }
        public void Close()
        {
            _sw.Close();
        }
    }
}
