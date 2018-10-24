using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek laipsnu lauke?");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dabar lauke yra:\n {0} °C\n {1} °F\n {2} °K", x,x + 273.15, x* 9 / 5 + 32);
        }
    }
}
