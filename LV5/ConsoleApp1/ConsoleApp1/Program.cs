using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 10 cjelobrojih vrijednosi!");
            List<int> lista = new List<int>();
            bool chk = false;
            do
            {
                try
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("Unesite {0}. vrijednost", i);
                        lista.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                }
                catch (Exception e)
                {
                    lista.Clear();
                    Console.WriteLine(e.Message);

                }
                finally
                {
                    if (lista.Count == 10)
                    {
                        chk = true;
                    }
                }
            } while (!chk);
            Console.WriteLine("Lista prije uklanjanja:");
            for(int i = 0; i < lista.Count; i++)
            {
                if(i == lista.Count - 1)
                {
                    Console.WriteLine(lista[i]);
                }
                else
                {
                    Console.Write(lista[i]+ " ");
                }
            }
            Console.WriteLine("Unesite cijelobrojnu vrijednost koju želite ukloniti iz liste!");
            int br = Convert.ToInt32(Console.ReadLine());
            lista.RemoveAll(t => t == br);
            for (int i = 0; i < lista.Count; i++)
            {
                if (i == lista.Count - 1)
                {
                    Console.WriteLine(lista[i]);
                }
                else
                {
                    Console.Write(lista[i] + " ");
                }
            }
        }
    }
}