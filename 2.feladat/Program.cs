using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] homerseklet = { 12, 8, -1, 5, 14, 7, 2 };
            Console.WriteLine("A heti hőmérséklet:");
            Console.WriteLine("12  8  -1  5  14  7  2");
            int legalacsonyabb = -1;  
            int legmagasabb = 14;
            int atlag = 6_7;
            for (int i = 0; i < homerseklet.Length; i++)
            {
                Console.WriteLine(homerseklet[i]);
            }
            Console.WriteLine($"A legalacsonyabb hőmérséklet {legalacsonyabb}");
            Console.WriteLine($"legmagasabb hőmérséklet {legmagasabb}");
            Console.WriteLine($"A heti átlag hőmérséklet {atlag}");

            

            Console.ReadKey();
        }
    }
}
