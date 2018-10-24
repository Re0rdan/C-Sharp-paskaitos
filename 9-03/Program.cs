using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.words();
        }
        public void words()
        {
            var a = "pirmas";
            var b = "antras";
            var c = "trecias";

            Console.WriteLine("-" + a);
            Console.WriteLine("-" + b);
            Console.WriteLine("-" + c);
        }
    }
}
