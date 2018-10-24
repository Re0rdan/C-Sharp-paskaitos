using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite penkis skirtingus skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            var d = Convert.ToDouble(Console.ReadLine());
            var e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Jusu skaiciai: {0} {1} {2} {3} {4}\nJusu skaiciaus vidurkis: {5}",a,b,c,d,e,(a+b+c+d+e)/5);
        }
    }
}
