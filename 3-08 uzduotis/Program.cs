using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 69;

            Console.WriteLine("{0} = {1}+{2} = {3}", x, x / 10, x % 10, x / 10 + x % 10);
        }
    }
}
