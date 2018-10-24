using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Gyvūnas:");
            var x = Console.ReadLine();
            Console.WriteLine("Šeima:");
            var y = Console.ReadLine();
            Console.WriteLine("Regionas, kuriame galima sutikti: ");
            var z = Console.ReadLine();
            Console.WriteLine(x + " priklauso " + y + " seimai ir yra randamas " + z);
        }
    }
}
