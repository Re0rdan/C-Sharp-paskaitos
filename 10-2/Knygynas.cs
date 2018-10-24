using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2
{
    class Knygynas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Knyga> Knygos { get; private set; }

        public Knygynas(string pavadinimas, string adresas, List<Knyga> knygos)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Knygos = knygos;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Knygyno pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas:" + Adresas);
            Console.WriteLine("--------------------");
            Console.WriteLine("Jame turimos knygos:");
            Console.WriteLine("--------------------");
            foreach (var knyga in Knygos)
            {
                knyga.Isvedimas();
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Didziausia knyga:");
            var didziausia = DidziausiaKnyga();
            didziausia.Isvedimas();


            Console.WriteLine();
        }

        public Knyga DidziausiaKnyga()
        {
            var didz = Knygos.First();
            foreach (var knyga in Knygos)
            {
                if (knyga.Puslapiai > didz.Puslapiai)
                {
                    didz = knyga;
                }
            }
            return didz;
        }
        public double BendraApyv()
        {
            var BApyv = 0.00;
            foreach (var knyga in Knygos)
            {
                
                BApyv += knyga.Apyv();
            }
            return BApyv;
        }
    }
}