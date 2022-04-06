using System;

namespace ZD4
{
    class Program
    {
        public enum Mjeseci
        {
            Sijecanj,
            Veljaca, 
            Ozujak, 
            Travanj,
            Svibanj,
            Lipanj,
            Srpanj,
            Kolovoz,
            Rujan,
            Listopad,
            Studeni,
            Prosinac
        }
        static void Main(string[] args)
        {
            Console.WriteLine("IZBORNIK");
            string[] values = Enum.GetNames(typeof(Mjeseci));
            int p = 1, n = 0;
            foreach (string s in values)
            {
                Console.WriteLine(p+ " - " + s);
                p++;
            }
            int[] x = new int[13];
            char c;
            string unos = "";
            bool esc = false;
            float f;
            do
            {
                try
                {
                    unos = "";
                    do
                    {
                        c = Console.ReadKey().KeyChar;
                        unos = unos + c;
                    } while (!((int)ConsoleKey.Escape == c || c== (int)ConsoleKey.Enter));

                    if (c == (int)ConsoleKey.Escape)
                        break;
                    Console.WriteLine();
                    n = Convert.ToInt32(unos);
                }
                catch (Exception e)
                {
                    if (float.TryParse(unos, out f))
                    {
                        Console.WriteLine(e.Message);
                    }
                    else
                    {
                        StringIznimka e1 = new StringIznimka("Ne mogu pretvoriti string u int");
                        Console.WriteLine(e1.Message);
                        string[] mjeseci = Enum.GetNames(typeof(Mjeseci));

                        for (int i = 0; i < mjeseci.Length; i++)
                        {
                            Console.WriteLine("{0}: {1}", mjeseci[i], x[i + 1]);
                        }
                        Console.WriteLine("Pogresno uneseno: {0}", x[0]);
                        break;
                    }

                }
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine(Mjeseci.Sijecanj);
                            x[n]++;
                            break;
                        case 2:
                            Console.WriteLine(Mjeseci.Veljaca);
                            x[n]++;
                            break;
                        case 3:
                            Console.WriteLine(Mjeseci.Ozujak);
                            x[n]++;
                            break;
                        case 4:
                            Console.WriteLine(Mjeseci.Travanj);
                            x[n]++;
                            break;
                        case 5:
                            Console.WriteLine(Mjeseci.Svibanj);
                            x[n]++;
                            break;
                        case 6:
                            Console.WriteLine(Mjeseci.Lipanj);
                            x[n]++;
                            break;
                        case 7:
                            Console.WriteLine(Mjeseci.Srpanj);
                            x[n]++;
                            break;
                        case 8:
                            Console.WriteLine(Mjeseci.Kolovoz);
                            x[n]++;
                            break;
                        case 9:
                            Console.WriteLine(Mjeseci.Rujan);
                            x[n]++;
                            break;
                        case 10:
                            Console.WriteLine(Mjeseci.Listopad);
                            x[n]++;
                            break;
                        case 11:
                            Console.WriteLine(Mjeseci.Studeni);
                            x[n]++;
                            break;
                        case 12:
                            Console.WriteLine(Mjeseci.Prosinac);
                            x[n]++;
                            break;
                        default:
                            x[0]++;
                            break;
                    }
            } while (!esc);
        }
    }
}
