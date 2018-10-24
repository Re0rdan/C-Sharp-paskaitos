using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{

    class Lektuvas
    {
        public int SparnuIlgis;
        public string Pavadinimas;
        public int Vietos;
        public string Klase;
        public int VarikiuSkaicius;
        public string VarikliuTipas;
        public string Tinkamumas;

        public Lektuvas()
        {

        }
        public Lektuvas(int sparnuIlgis, string pavadinimas, int vietos, string klase, int varikiuSkaicius, string varikliuTipas)
        {
        SparnuIlgis= sparnuIlgis;
        Pavadinimas= pavadinimas;
        Vietos= vietos;
        Klase= klase;
        VarikiuSkaicius= varikiuSkaicius;
        VarikliuTipas= varikliuTipas;
        
    }

    public void Isvedimas()
        {
            Tinka();
            Console.WriteLine("Lektuvas {0} turi {1} vietu, jo sparnu ilgis yra {2} metru.",Pavadinimas,Vietos, SparnuIlgis);
            Console.WriteLine("Jis priskiriamas {0} klasei turi {1} {2} variklius", Klase, VarikiuSkaicius,VarikliuTipas);
            Console.WriteLine("Toks lėktuvas yra pritaikytas veikti kaip {0} lektuvas", Tinkamumas);
            Console.WriteLine();
        }

    public void Tinka()
        {
            if (Vietos > 40)
            {
                Tinkamumas = "Keleivinis";
            }
            else if (Vietos < 40 && Vietos > 3)
            {
                Tinkamumas = "Privatus";
            }
            else if (Vietos < 3)
            {
                Tinkamumas = "darbinis";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Lektuvas1 = new Lektuvas();
            var Lektuvas2 = new Lektuvas();

            Lektuvas1.Pavadinimas = "Boeying";
            Lektuvas1.Vietos = 600;
            Lektuvas1.Klase = "Tarpatlantinis";
            Lektuvas1.SparnuIlgis = 500;
            Lektuvas1.VarikliuTipas = "Turbo";
            Lektuvas1.VarikiuSkaicius = 4;

            Lektuvas2.Pavadinimas = "Kukuruznikas";
            Lektuvas2.Vietos = 1;
            Lektuvas2.Klase = "Ukinis";
            Lektuvas2.SparnuIlgis = 2;
            Lektuvas2.VarikliuTipas = "Sraigtinis";
            Lektuvas2.VarikiuSkaicius = 1;

            Lektuvas1.Isvedimas();
            Lektuvas2.Isvedimas();
            var lektuvas3 = new Lektuvas(5, "f15", 2, "Naikintuvas", 2, "Reaktyvinis");
            lektuvas3.Isvedimas();



        }
    }
}
