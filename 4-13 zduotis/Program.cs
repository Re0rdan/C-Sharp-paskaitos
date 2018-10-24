using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_13_zduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk koki nors simboli:");
            var x = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("{0}{0}{0}\n{0}{0}{0}\n{0}{0}{0}",x);
        }
    }
}
