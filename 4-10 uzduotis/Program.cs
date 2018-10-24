using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius:");
            var x = Convert.ToDouble(Console.ReadLine());
            var y = Convert.ToDouble(Console.ReadLine());
            var z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} ; {1} ; {2}.\nSkaiciu vidurkis: {3}",x,y,z,(x+y+z)/3);

        }
    }
}
