using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_09
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.mieravimas(4, 5);
            p.mieravimas(8, 2);
            p.mieravimas(4, 4);
        }

        public void mieravimas(int a,int b)
        {
            if (a > b)
            {
                Console.WriteLine("{0} yra didesnis", a);
            }
            else if (a<b)
            {
                Console.WriteLine("{0} yra didesnis", b);
            }
            else if(a==b)
            {
                Console.WriteLine("skaiciai yra lygus");
            }
        }
    }
}
