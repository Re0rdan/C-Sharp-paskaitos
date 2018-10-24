using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite kita skaičiu");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jūsų skaičių suma: {0}", (x + y));
        }
    }
}
