using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Iveskite 10 norimu skaiciu");
            var x =new List<double>();
            
            for (int y = 1; y <= 10; y++)
            {   var a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Skaicius {0}: {1}", y, a);
                x.Add(a);
                
            }
            for (int i = 0; i < x.Count; i++)
            {
                Console.Write("{0} ", x[i]);
            }
            Console.WriteLine();
        }
    }
}
