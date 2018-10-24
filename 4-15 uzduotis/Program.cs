using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jusu vardas ir pavarde");
            var x = Console.ReadLine();
            Console.WriteLine("Jusu gimimo metai");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu spitselibe");
            var z = Console.ReadLine();
            Console.WriteLine("Kokiu etatu dirbate (nuo 0 iki 1)");
            var q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jusu alga");
            var c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} ({1}m.) dirba {2} {3} etatu ir uždirba {4}", x, 2018 - y, z,q, c);
        }
    }
}
