using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda");
            var x = Console.ReadLine();
            Console.WriteLine("Iveskite savo amziu");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu vardas: {0}\nJusu amzius: {1}", x, y);
        }
    }
}
