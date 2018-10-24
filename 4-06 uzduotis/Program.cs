using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveikaji skaičiu:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu skaicius: {0}\nJusu skaiciaus kvadratas: {1} ", x, Math.Pow(x,2));
        }
    }
}
