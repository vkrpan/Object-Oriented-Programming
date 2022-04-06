using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace VUV_JednostavnaBanka
{
    class Program
    {
        static void Main(string[] args)
        {            //List<Klijent> lista = dohvatiKlijente();
            //foreach(Klijent k in lista)
            //{
            //    Console.WriteLine(k.ime + " " + k.prezime + " " + k.datRodenja + " " + k.spol + " " + k._OIB + " " + k.idKlijenta);
            //}
            int cntr = 1;
            List<Klijent> listaKlijenata = dohvatiKlijente();
            List<Racun> listaRacuna = dohvatiRacune();
            List<Bankar> listaBankara = dohvatiBankare();
            List<ITransakcije> listaTransakcija = dohvatiTransakcije();
            foreach (Klijent k in listaKlijenata)
            {
                Console.WriteLine(cntr + ". " + k.ime + " " + k.prezime + " " + k._OIB);
                foreach(Racun r in listaRacuna)
                {
                    if(k.idKlijenta == r._idKlijenta)
                    {
                        foreach(Bankar b in listaBankara)
                        {
                            if(r._idBankara == b.idBankara)
                            {
                                Console.WriteLine("{0} je otvorio racun u {1}, {2} u {3} sati", b.ime, r._poslovnica, r._datum, r._vrijeme);
                                foreach(ITransakcije tr in listaTransakcija)
                                {
                                    if(tr._brRacuna == r._brRacuna)
                                    {
                                        Console.WriteLine("Datum: {0} u {1}, bankar: {2}, poslovnica: {3}, iznos transakcije: {4}", tr._datum, tr._vrijeme, b.ime, tr._poslovnica, tr._iznos);
                                    }
                                }
                            }
                        }
                    }
                }
                cntr++;
            }
        }
        static List<Klijent> dohvatiKlijente()
        {
            List<Klijent> klijenti = new List<Klijent>();
            string sadrzaj_xml = "";
            StreamReader osr = new StreamReader("klijenti.xml");
            using (osr)
            {
                sadrzaj_xml = osr.ReadToEnd();
            }
            XmlDocument xml_datoteka = new XmlDocument();
            xml_datoteka.LoadXml(sadrzaj_xml);
            var atributi = xml_datoteka.SelectNodes("//Klijenti/klijent");
            foreach (XmlElement sadrzaj in atributi)
            {
                klijenti.Add(new Klijent(sadrzaj.Attributes["ime"].Value,
                                         sadrzaj.Attributes["prezime"].Value,
                                         sadrzaj.Attributes["datRod"].Value,
                                         sadrzaj.Attributes["spol"].Value,
                                         sadrzaj.Attributes["OIB"].Value,
                                         sadrzaj.Attributes["idKlijenta"].Value));
            }
            osr.Close();
            return klijenti;
        }
        static List<Racun> dohvatiRacune()
        {
            List<Racun> racuni = new List<Racun>();
            string sadrzaj_xml = "";
            StreamReader osr = new StreamReader("Racuni.xml");
            using (osr)
            {
                sadrzaj_xml = osr.ReadToEnd();
            }
            XmlDocument xml_datoteka = new XmlDocument();
            xml_datoteka.LoadXml(sadrzaj_xml);
            var atributi = xml_datoteka.SelectNodes("//Racuni/racun");
            foreach (XmlElement sadrzaj in atributi)
            {
                racuni.Add(new Racun(sadrzaj.Attributes["idKlijenta"].Value,
                                     sadrzaj.Attributes["idBankara"].Value,
                                     sadrzaj.Attributes["brRacuna"].Value,
                                     sadrzaj.Attributes["vrstaRacuna"].Value,
                                     sadrzaj.Attributes["datum"].Value,
                                     sadrzaj.Attributes["vrijeme"].Value,
                                     sadrzaj.Attributes["poslovnica"].Value));
            }
            osr.Close();
            return racuni;
        }
        static List<Bankar> dohvatiBankare()
        {
            List<Bankar> bankari = new List<Bankar>();
            string sadrzaj_xml = "";
            StreamReader osr = new StreamReader("Bankari.xml");
            using (osr)
            {
                sadrzaj_xml = osr.ReadToEnd();
            }
            XmlDocument xml_datoteka = new XmlDocument();
            xml_datoteka.LoadXml(sadrzaj_xml);
            var atributi = xml_datoteka.SelectNodes("//Bankari/bankar");
            foreach (XmlElement sadrzaj in atributi)
            {
                bankari.Add(new Bankar(sadrzaj.Attributes["ime"].Value,
                                     sadrzaj.Attributes["prezime"].Value,
                                     sadrzaj.Attributes["datRod"].Value,
                                     sadrzaj.Attributes["spol"].Value,
                                     sadrzaj.Attributes["idBankara"].Value));
            }
            osr.Close();
            return bankari;
        }
        static List<ITransakcije> dohvatiTransakcije()
        {
            List<ITransakcije> transakcije = new List<ITransakcije>();
            string sadrzaj_xml = "";
            StreamReader osr = new StreamReader("Transakcije.xml");
            using (osr)
            {
                sadrzaj_xml = osr.ReadToEnd();
            }
            XmlDocument xml_datoteka = new XmlDocument();
            xml_datoteka.LoadXml(sadrzaj_xml);
            var atributi = xml_datoteka.SelectNodes("//Transakcije/transakcija");
            foreach (XmlElement sadrzaj in atributi)
            {
                if (Convert.ToDouble(sadrzaj.Attributes["iznos"].Value) > 0)
                {
                    transakcije.Add(new Uplata(sadrzaj.Attributes["idT"].Value,
                                     Convert.ToDouble(sadrzaj.Attributes["iznos"].Value),
                                     sadrzaj.Attributes["poslovnica"].Value,
                                     sadrzaj.Attributes["vrijeme"].Value,
                                     sadrzaj.Attributes["datum"].Value,
                                     sadrzaj.Attributes["brRacuna"].Value));
                }
                else
                {
                    transakcije.Add(new Isplata(sadrzaj.Attributes["idT"].Value,
                                     Convert.ToDouble(sadrzaj.Attributes["iznos"].Value),
                                     sadrzaj.Attributes["poslovnica"].Value,
                                     sadrzaj.Attributes["vrijeme"].Value,
                                     sadrzaj.Attributes["datum"].Value,
                                     sadrzaj.Attributes["brRacuna"].Value));
                }

            }
            osr.Close();
            return transakcije;
        }
    }
}
