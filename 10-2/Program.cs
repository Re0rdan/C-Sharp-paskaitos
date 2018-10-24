using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var knygynas = new Knygynas("Pegasas", "Akropolis", new List<Knyga>
            {
                new Knyga("Haris Poteris", "J.K.Rowling", 874, "fantastika", 15.50, 500),
            new Knyga("Ziedu valdovas: Ziedo brolija", "Tolkien", 795, "fantastika", 20.00, 800),
            new Knyga("Ziedu valdovas: Du bokstai", "Tolkien", 890, "fantastika", 25.00, 800),
            new Knyga("Ziedu valdovas: Karalius sugryzimas", "Tolkien", 950, "fantastika", 30.00, 800)
            });

        knygynas.Isvedimas();
        }
    }
}
