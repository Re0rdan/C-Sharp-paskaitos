using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new List<string>();
            Console.WriteLine("Kiek vardu norite ivesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite vardus:");

            for (int i=0; i< kiek; i++)
            {
                var vardas = Console.ReadLine();
                vardai.Add(vardas);
            }
            Console.WriteLine("Pirmas ir paskutinis ivesti vardai: {0} ir {1}", vardai.First<string>(), vardai.Last<string>());
        }
    }
    
}
