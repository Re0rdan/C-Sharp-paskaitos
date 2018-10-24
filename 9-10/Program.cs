using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodziai = new List<string>
            {
                "medis",
                "kotas",
                "saka",
                "lapas",
                "kamienas",
                "gile"
            };

            p.ilg(zodziai);
        }
        public void ilg(List<string> zodziai)
        {
            var x = 0;
            string y = "o";
            foreach (var zodis in zodziai)
            {
                if (zodis.Length > x)
                {
                    x = zodis.Length;
                    y = zodis;
                }
            }
            Console.WriteLine("Ilgiausias zodis: {0}", y);
        }
    }
}
