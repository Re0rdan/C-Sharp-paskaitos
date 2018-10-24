using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pazymiai = new List<Int32>();
            Console.WriteLine("Kiek pazymiu ivesite?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pazymius:");
            for (int i=0; i<kiek; i++)
            {
                var pazymys = Convert.ToInt32(Console.ReadLine());
                pazymiai.Add(pazymys);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Didziausias pazymys: {0}", pazymiai.Max());
            Console.WriteLine("Maziausias pazymys: {0}", pazymiai.Min());
            Console.WriteLine("Vidurkis: {0}", pazymiai.Average());
            var rand = new Random();
            var indeksas = rand.Next(pazymiai.Count);
            Console.WriteLine("Atsitiktinis pazymys: {0}", pazymiai[indeksas]);
            var x = 0;
            for (int i=0; i<kiek; i++)
            {
                if (pazymiai[i] == 10)
                {
                    x++;
                }
            }
            Console.WriteLine("Kiek desimtuku yra?: {0}", x);
            var y = 0;
            for (int i = 0; i < kiek; i++)
            {
                if (pazymiai[i]<=4)
                {
                    y++;
                }
            }
            Console.WriteLine("Kiek neigiamu pazymiu yra?: {0}", y);
        }
    }
}
