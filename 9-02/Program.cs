using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.mentas();
        }

        public void mentas()
        {
            var name = "Serioza";
            var surname = "Vafliauskas";
            var age = 55;
            var wage = "600€";
            var rate = 1;
            var spec = "detektyvas";

            Console.WriteLine("Pareigunas {0} {1} ({2} m.) dirbantis {3} etatu(o) yra {4}",name, surname,age,rate,spec);
            Console.WriteLine("Jo alga: {0}", wage);
        }
    }
}
