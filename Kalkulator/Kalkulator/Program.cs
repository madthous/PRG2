using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double res = 0;
            double a = 0;
            double b = 0;
            bool o = true;
            Console.WriteLine("Zadej numero uno/ základ mocniny či odmocniny:");
            while (a == 0)
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine($"Povedlo se, hodnotoš: {a}");
                }
                else
                {
                    Console.WriteLine("Zkus to znova");
                }

            Console.WriteLine("Zadej numero dos/ mocninu či odmocninu:");
            while (b == 0)
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine($"Povedlo se, hodnotoš: { b}");
                }
                else
                {
                    Console.WriteLine("Zkus to znova");
                }
            Console.WriteLine("Zadej název operace:");
            Console.WriteLine("Máš na výběr z: součet, či + ; odečet, či - ; násobení, či * ; dělení, či / ; modulo, či % ; mocnina ; odmocnina");
            while(o)
                {
                o = false;
                string op = Console.ReadLine();
                switch (op)
                {
                    case ("součet"):
                        res = a + b;
                        break;
                    case ("+"):
                        res = a + b;
                        break;
                    case ("odečet"):
                        res = a - b;
                        break;
                    case ("-"):
                        res = a - b;
                        break;
                    case ("násobení"):
                        res = a * b;
                        break;
                    case ("*"):
                        res = a * b;
                        break;
                    case ("dělení"):
                        res = a / b;
                        break;
                    case ("/"):
                        res = a / b;
                        break;
                    case ("modulo"):
                        res = a % b;
                        break;
                    case ("%"):
                        res = a % b;
                        break;
                    case ("mocnina"):
                        res = Math.Pow(a, b);
                        break;
                    case ("odmocnina"):
                        res = Math.Pow(a, 1/b);
                        break;


                    default:
                        Console.WriteLine("Zkus to znova");
                        o = true;
                        break;
                }
                
            }
            
            Console.WriteLine("Výsledek činí: " + res);
            Console.ReadKey();
        }
    }
}
