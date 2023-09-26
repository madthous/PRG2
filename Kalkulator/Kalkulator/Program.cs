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
            double res = 1;
            double lastres = 0;
            string input;
            double a;
            double b;
            bool o;
            bool p = true;
            bool q = true;
            Console.WriteLine("Zmáčkni jakoukoli klávesu pro kalkulátor");
            while (p)
            {
                a = 0;
                b = 0;
                o = true;
                q = true;
                Console.WriteLine("Zadej numero uno/základ");
                while (a == 0)
                {
                    if (lastres == res)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Chceš zadat minulý výsledek jako numero uno?");
                        while (q)
                        {
                            input = Console.ReadLine();
                            if (input == "ano")
                            {
                                a = lastres;
                                q = false;
                            }
                            else if (input != "ne")
                            {
                                Console.WriteLine(" ano nebo ne");
                            }
                            else
                            {
                                Console.WriteLine("Tak zadej numero uno");
                                while (q)
                                {
                                    if (double.TryParse(Console.ReadLine(), out a))
                                    {
                                        Console.WriteLine($"Povedlo se, hodnotoš: {a}");
                                        q = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Zkus to znova");
                                    }
                                }
                                
                            }
                        }
                        
                    }
                    else {
                        if (double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine($"Povedlo se, hodnotoš: {a}");
                        }
                        else
                        {
                            Console.WriteLine("Zkus to znova");
                        }
                    }
                    
                }
                    

                Console.WriteLine("Zadej numero dos:");
                while (b == 0)
                    if (double.TryParse(Console.ReadLine(), out b))
                    {                       
                        Console.WriteLine($"Povedlo se, hodnotoš: {b}");
                        /*Dolárek mi poradil ChatGPT*/
                    }
                    else
                    {
                        Console.WriteLine("Zkus to znova");
                    }
                Console.WriteLine("Zadej název operace:");
                Console.WriteLine("Máš na výběr z: součet, či + ; odečet, či - ; násobení, či * ; dělení, či / ; modulo, či % ; mocnina ; odmocnina ; log ; ");
                while (o)
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
                            res = Math.Pow(a, 1 / b);
                            break;
                        case ("log"):
                            res = Math.Log(b, a);
                            break;



                        default:
                            Console.WriteLine("Zkus to znova");
                            o = true;
                            break;
                    }
                }
                    lastres = res;
                    Console.WriteLine("Výsledek činí: " + res);
                Console.WriteLine("Zmáčkni ESC pro ukončení, nebo cokoliv jinýho pro pokračování.");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        p = false;
                    }
                    
                
            }
        }
    }
}
