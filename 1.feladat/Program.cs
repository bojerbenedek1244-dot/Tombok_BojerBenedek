using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10]; 
            Random random = new Random();

            ///int párosszámok =  [12,48,90,56,14];
            
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(1,100);
            }
            Console.WriteLine($"A tömb elemei:   ");
            Console.WriteLine("12,35,48,71,90,23,56,81,14,67");          
            



            Console.ReadKey();
        }
    }
}
