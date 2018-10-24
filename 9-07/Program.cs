using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.sent("Juozas", "Jockus", 25, "batsiuvys");
            p.sent("Petras", "Pockus", 83, "kareivis");
        }
        public void sent(string a,string b, int c, string d)
        {
            Console.WriteLine("{0} {1} yra {2} ir yra {3}", a,b,c,d);
        }
    }
}
