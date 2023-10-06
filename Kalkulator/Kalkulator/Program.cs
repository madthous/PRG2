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
            double lastres = 1;
            string input;
            string op;
            double a;
            double b;
            bool q = false;
            int n;
            Console.WriteLine("Vítej v kalkulačce.");
            Console.WriteLine("Zmáčkni cokoliv pro pokračování.");
            Console.WriteLine("PS: Podle mě nemá význam počítat s nulou, takže ti nepůjde zadat");
            Console.ReadKey();
            while (!q)
            {
                Console.WriteLine("Pomůcka: Numero uno = základ mocniny, odmocniny, či logaritmu.");
                Console.WriteLine("Při převodu do jiné soustavy se jedná o překládané číslo.");
                Console.WriteLine("Numero dos = exponent mocniny, odmocniny, či argument logaritmu.");
                Console.WriteLine("Při převodu do jiné soustavy se jedná o danou soustavu.");
                n = 0;
                input = "";
                a = 0;
                b = 0;
                q = true;
                Console.WriteLine("Zadej numero uno/základ");
                while (a == 0)
                {
                    if (lastres == res)
                    {
                        Console.WriteLine();
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
                                    if (double.TryParse(Console.ReadLine(), out a) && a != 0)
                                    {
                                        Console.WriteLine($"Povedlo se, hodnotoš: {a}");
                                        //Dolárek poradil ChatGPT
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


                    else
                    {
                        if (double.TryParse(Console.ReadLine(), out a) && a != 0)
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
                {
                    if (lastres == res)
                    {
                        q = true;
                        Console.WriteLine();
                        Console.WriteLine("Chceš zadat minulý výsledek jako numero dos?");
                        while (q)
                        {
                            input = Console.ReadLine();
                            if (input == "ano")
                            {
                                b = lastres;
                                q = false;
                            }
                            else if (input != "ne")
                            {
                                Console.WriteLine(" ano nebo ne");
                            }
                            else
                            {
                                Console.WriteLine("Tak zadej numero dos");
                                while (q)
                                {
                                    if (double.TryParse(Console.ReadLine(), out b) && b!= 0)
                                    {
                                        Console.WriteLine($"Povedlo se, hodnotoš: {b}");
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


                    else
                    {
                        if (double.TryParse(Console.ReadLine(), out b)&& b != 0)
                        {
                            Console.WriteLine($"Povedlo se, hodnotoš: {b}");
                        }
                        else
                        {
                            Console.WriteLine("Zkus to znova");
                        }
                    }

                }

                q = true;
                res = 0;
                Console.WriteLine("Zadej název operace:");
                Console.WriteLine("Máš na výběr z: součet, či + ; odečet, či - ; násobení, či * ; dělení, či / ; modulo, či % ; mocnina ; odmocnina ; log ; ");
                Console.WriteLine("Pro převod numero uno do soustavy definované numero dos napište: prevod");
                while (q)
                {
                    q = false;
                    op = Console.ReadLine();
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
                        case ("prevod"):
                            {
                                q = true;
                                while (q)
                                {
                                    if (2 <= b && b <= 9)
                                    {
                                        a = Math.Floor(a);
                                        b = Math.Floor(b);
                                        //funkce dolní celá část
                                        while (a > 1)
                                        {
                                            res += (a % b) * Math.Pow(10, n);
                                            //při každé iteraci přidá zbytek po dělení "do správné číslice"
                                            a = Math.Floor(a / b);
                                            //abychom zůstali v celých číslech
                                            n++;
                                            //určuje správnou číslici
                                        }
                                        res += (a % b) * Math.Pow(10, n);
                                        //tohle řeší první číslici zkonvertovaného čísla
                                        q = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Špatné 'b'");
                                        while (!double.TryParse(Console.ReadLine(), out b) || 2 > b || b > 9)
                                        {
                                            Console.WriteLine("Soustava, nebo-li 'b' musí být mezi dvojkou a devítkou (včetně)");
                                            //se soustavami, vyššími než 10 jsou problémy (písmena nepatří do čísel)
                                        }
                                    }
                                }                                
                            }
                            
                            break;
                        /*
                        Disclaimer:
                        Vypracováno ve spolupráci s @Tomáš_Pobořil
                        */

                        default:
                            Console.WriteLine("Zkus to znova");
                            q = true;
                            break;
                    }
                }


                    lastres = res;
                    Console.WriteLine($"Výsledek činí: {res}");
                Console.WriteLine("Zmáčkni ESC pro ukončení, nebo cokoliv jinýho pro pokračování.");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        q = true;
                    }
                Console.Clear();
            }
        }
    }
}
