using System;
using System.Text;

namespace Merkkijonot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Merkkijonot();
            Merkkijonot2();

            Console.ReadLine();
        }

        // H-I-D-A-S-!!!
        static void Merkkijonot()
        {
            string s = "";
            DateTime alku = DateTime.Now;
            for (int i = 0; i < 1000000; i++)
            {
                s = s + "AAA";
            }
            DateTime loppu = DateTime.Now;

            TimeSpan kesto = loppu - alku;
            Console.WriteLine(kesto.TotalSeconds);
        }

        static void Merkkijonot2()
        {
            StringBuilder s = new StringBuilder();
            DateTime alku = DateTime.Now;
            for (int i = 0; i < 1000000; i++)
            {
                s.Append("AAA");
            }
            DateTime loppu = DateTime.Now;

            TimeSpan kesto = loppu - alku;
            Console.WriteLine(kesto.TotalSeconds);
        }
    }
}
