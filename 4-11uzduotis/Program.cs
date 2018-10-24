using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveikaji skaiciu:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} * 1= {1}",x,x*1);
            Console.WriteLine("{0} * 2= {1}", x, x * 2);
            Console.WriteLine("{0} * 3= {1}", x, x * 3);
            Console.WriteLine("{0} * 4= {1}", x, x * 4);
            Console.WriteLine("{0} * 5= {1}", x, x * 5);
            Console.WriteLine("{0} * 6= {1}", x, x * 6);
            Console.WriteLine("{0} * 7= {1}", x, x * 7);
            Console.WriteLine("{0} * 8= {1}", x, x * 8);
            Console.WriteLine("{0} * 9= {1}", x, x * 9);
            Console.WriteLine("{0} * 10= {1}", x, x * 10);
        }
    }
}
