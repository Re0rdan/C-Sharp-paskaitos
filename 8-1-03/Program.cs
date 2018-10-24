using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_03
{
    class Program
    {
        static void Main(string[] args)
        { 
            for (int i=1; i<21; i++)
            {
                var x = 0 + i;
                if (x==1||x==4||x==7||x==10||x==13||x==16||x==19)
                Console.Write("[{0}]", x);
            }
            Console.WriteLine();
        }

    }
}
