using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.word("medis");
            p.word("lapas");
            p.word("penis");
            p.word("lokomotyvas");
            p.word("gaistras");
        }
        public void word(string a)
        {
            Console.WriteLine("--{0}--", a);
        }
    }
}
