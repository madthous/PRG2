using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _26_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int human = 0;
            int kompl = 0;
            bool g = true;
            Console.WriteLine("Kámen, nůžky nebo papír?");
            string input = Console.ReadLine();
            while(g)
            {
                int komplinput = 0;
                komplinput = rnd.Next(1, 4);
                switch ($"{komplinput}input")
                {
                    case ("1nůžky"):
                        Console.WriteLine("Kompjůtr dal kámen a prohrál");
                        human++;
                        break;
                    case ("1papír"):
                        Console.WriteLine("Kompjůtr hodil kámen a vyhrál");
                        kompl++;
                        break; 
                    case ("2kámen"):
                        Console.WriteLine("Kompjůtr hodil nůžky a prohrál");
                        human++;
                        break;
                    case ("2papír"):
                        Console.WriteLine("Kompjůtr hodil nůžky a vyhrál");
                        kompl++;
                        break;
                    case ("3nůžky"):
                        Console.WriteLine("Kompjůtr hodil papír a prohrál");
                        human++;
                        break;
                    case ("3kámen"):
                        Console.WriteLine("Kompjůtr hodil papír a vyhrál");
                        kompl++;
                        break;
                    default:
                        Console.WriteLine("Plichta");
                        break;
                }
                Console.WriteLine(komplinput);
                Console.WriteLine("Pro ukončení zmáčkni ESC, pro pokračování jakoukoli jinou klávesu");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    g = false;
                }
                
            }
            
        }
    }
}
