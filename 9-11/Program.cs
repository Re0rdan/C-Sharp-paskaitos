using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var trum1 =new List<string> { "koja", "ranka", "birka", "obuolys", "salionas" };
            var trum2 = new List<string> { "vienas", "du", "trys", "keturi", "penki" };
            p.trumpas(trum1);
            p.trumpas(trum2);
                
        }
        public void trumpas(List<string> a)
        {
            var x = 500;
            var y = "asdasdasdasdasdsadasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdsdasd";
            foreach (var b in a)
            {
                if (b.Length < x)
                {
                    x = b.Length;
                    y = b;
                }
            }
            foreach (var b in a)
            { 
                if (b==y)
                {
                Console.Write("({0})", y);
                }
                else
                {
                Console.Write(b + " ");
                }
            }
            Console.WriteLine();
        }

    }
}
