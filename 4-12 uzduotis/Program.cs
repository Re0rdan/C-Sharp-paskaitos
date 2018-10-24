using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius:");
            var x = Convert.ToDouble(Console.ReadLine());
            var y = Convert.ToDouble(Console.ReadLine());
            var z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skaicius                :{0};{1};{2}.",x,y,z);
            Console.WriteLine("Skaiciu kvadratai       :{0};{1};{2}.",Math.Pow(x,2), Math.Pow(y, 2),Math.Pow(z, 2));
            Console.WriteLine("Skaiciu kubai           :{0};{1};{2}.", Math.Pow(x, 3), Math.Pow(y, 3), Math.Pow(z, 3));
            Console.WriteLine("Skaicius padalintas is 2:{0};{1};{2}.",x/2,y/2,z/2);


        }
    }
}
