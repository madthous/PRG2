using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int b = 0;
            int gold = 0;
            int n = 0;
            bool f = true;
            Random rnd = new Random();
            while (f) {
                gold = 0;
            Console.WriteLine("Zadej o kolik rollneš:");
            while (gold <= 1)
            {
                try
                {
                    gold = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    gold = 0;
                }
                
                if (gold <= 1) { Console.WriteLine("Zadej celé číslo, větší než jedna:"); }
            }
            Console.Clear();
            Console.WriteLine("Deathroll o " + gold);
            a = rnd.Next(1,gold+1);
            Console.WriteLine("Ty: " + a);
            
            while (a > 1) 
            {
                Console.WriteLine("Zmáčkněte SPACE pro pokračování: ");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar )
                {
                    b = a;
                    n++;
                    a = rnd.Next(1, b + 1);
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Ty: " + a);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Nepřítel: " + a);
                        Console.WriteLine();
                    }
                    
                }
                
                
            }
            if (n%2 == 1 )
            {
                Console.WriteLine("Vyhrál jsi " + gold + " goldů.");
            }
            else
            {
                Console.WriteLine("Prohrál jsi " + gold + " goldů.");
            }
                Console.WriteLine("Zmáčkněte ESC pro ukončení");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    f = false;
                }

        }
        }
    }
}
