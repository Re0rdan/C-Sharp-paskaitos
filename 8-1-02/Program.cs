using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i =0; i<16; i++)
            {
                var x = 0 + i;
                if (x == 0 || x % 2 ==0)
                {
                    Console.Write(x + " ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
