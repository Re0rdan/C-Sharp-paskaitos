using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;
            var y = 3;

            Console.WriteLine("suma: " + (x + y));
            Console.WriteLine("skirtumas: " + (x - y));
            Console.WriteLine("sumos ir skirtumo sandauga: " + (x + y) * (x - y));
            Console.WriteLine("sumos ir skirtumo dalmuo: " + (x + y) / (x - y));
        }
    }
}
