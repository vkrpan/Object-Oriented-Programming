using System;
using System.Collections.Generic;
using System.IO;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string tekst;
            try
            {
                FileStream fs = new FileStream("TextFile1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader sr = new StreamReader(fs);
                while((tekst = sr.ReadLine()) != null)
                {
                    Console.WriteLine(tekst);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            /*List<int> lista = new List<int>() { 1, 2, 3, 4, 5 };
            try
            {
                StreamWriter sw = new StreamWriter("tekst_pisanje.txt");
                foreach(int i in lista)
                {
                    sw.WriteLine(i);
                }
                Console.WriteLine("Pisanje zavrseno!");
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            string path = @"C:\Users\VK\Desktop\faks\2. semestar\OOP\LV6\LV6\LV6\bin\Debug\netcoreapp3.1\tekst.txt";
            string citaj = File.ReadAllText(path);
            Console.WriteLine(citaj);
        }
    }
}
