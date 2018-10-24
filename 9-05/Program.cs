using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.table();
        }
        public void table()
        {
            var rand =new Random();
            var skaiciai1 = new List<int>();
            var skaiciai2 = new List<int>();
            for (int i=0; i<6; i++)
            {
                skaiciai1.Add(rand.Next(100));
            }
            for (int i = 0; i < 6; i++)
            {
                skaiciai2.Add(rand.Next(100));
            }
            Console.WriteLine("{0} {1} {2} {3} {4}", skaiciai1[0], skaiciai1[1], skaiciai1[2], skaiciai1[3], skaiciai1[4]);
            Console.WriteLine("{0} {1} {2} {3} {4}", skaiciai2[0], skaiciai2[1], skaiciai2[2], skaiciai2[3], skaiciai2[4]);
            Console.WriteLine("{0} {1} {2} {3} {4}", skaiciai1[0]+ skaiciai2[0], skaiciai1[1] + skaiciai2[1],skaiciai1[2] + skaiciai2[2],skaiciai1[3] + skaiciai2[3],skaiciai1[4] + skaiciai2[4]);
        }
    }
}
