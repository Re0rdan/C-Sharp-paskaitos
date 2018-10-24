using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_09_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}\n{0} - {1} = {3}\n{0} / {1} = {4}\n{0} * {1} = {5}",x,y,x+y,x-y,(double)x/y,x*y);
        }
    }
}
