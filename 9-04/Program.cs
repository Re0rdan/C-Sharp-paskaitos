using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.name();
        }
        public void name()
        {
        Console.WriteLine("Iveskite savo varda");
        var x = Console.ReadLine();
        Console.WriteLine("Labas, {0}",x);
        }
    }
}
