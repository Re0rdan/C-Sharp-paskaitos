using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.isvedimas(4, 5);
            p.isvedimas(15, 25);
        }

        public void isvedimas(int a,int b)
        {
            suma(a,b);
            skirtumas(a, b);
            sandauga(a, b);
            dalmuo(a, b);
        }
        public void suma (int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
        }
        public void skirtumas(int a , int b)
        {
            Console.WriteLine("{0} - {1} = {2}",a,b,a-b);
        }
        public void sandauga(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a,b, a*b);
        }
        public void dalmuo(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}",a,b,(double)a/b);
        }

    }
}
