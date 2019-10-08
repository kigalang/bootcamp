using System;
using System.IO;
using System.Text;

namespace Muistinhallinta
{
    class Program
    {
        static void KirjoitaTiedostoon()
        {
            Directory.CreateDirectory(@"C:\Temp");
            FileStream tiedosto = new FileStream(@"C:\Temp\Oma.txt", FileMode.Create);
            string teksti = "Moi Turku!";
            tiedosto.Write(Encoding.UTF8.GetBytes(teksti));
            tiedosto.Close();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Metodi();
            //KirjoitaTiedostoon();

            int luku = 1234;
            TestaaParametreja(ref luku);
            Console.WriteLine("Kohta 3: " + luku);

            string merkkijono = "AAAA";
            TestaaParametreja2(merkkijono);
            Console.WriteLine("Kohta 3: " + merkkijono);

            OmaLuokka l = new OmaLuokka();
            l.Nimi = "M. Möttönen";
            TestaaParametreja3(l);
            Console.WriteLine("Kohta 3: " + l.Nimi);

            Console.ReadLine();
        }

        static void Metodi()
        {
            int[] luvut = new int[10000000];

            
        }

        static void TestaaParametreja(ref int luku)
        {
            Console.WriteLine("Kohta 1: "+ luku);

            luku = 9876;
            Console.WriteLine("Kohta 2: " + luku);
        }

        static void TestaaParametreja2(string merkkijono)
        {
            Console.WriteLine("Kohta 1: " + merkkijono);

            merkkijono = "BBBB";
            Console.WriteLine("Kohta 2: " + merkkijono);
        }

        static void TestaaParametreja3(OmaLuokka l)
        {
            Console.WriteLine("Kohta 1: " + l.Nimi);

            l.Nimi = "K. Rosberg";
            Console.WriteLine("Kohta 2: " + l.Nimi);
        }
    }
}

