using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var skaiciai = new List<int>();
            var z = 20;

            for (int i = 0; i < z; i++)
            {
                var a = rand.Next(1, 10);
                skaiciai.Add(a);
            }
            for (int i =0; i< skaiciai.Count; i++)
            {
                Console.Write("{0} ", skaiciai[i]);
                
            }
            Console.WriteLine();

            Console.WriteLine("maziausias skaicius:" + skaiciai.Min());
        }
    }
}
