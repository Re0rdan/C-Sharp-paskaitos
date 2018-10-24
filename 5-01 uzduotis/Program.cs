using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new int [16];
            var random = new Random();
            for (int i=0; i < x.Length; i++)
            {
                x[i] = random.Next(10);
            }
            for (int i=0; i<4; i++)
            {
                Console.Write(x[i] +" ");
            }
            Console.WriteLine();
            for (int i = 4; i < 8; i++)
            {
                Console.Write(x[i] + " ");
            }
                Console.WriteLine();
            for (int i = 8; i < 12; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
            for (int i = 12; i < 16; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
