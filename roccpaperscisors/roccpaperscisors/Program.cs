using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roccpaperscisors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int human = 0;
            int kompl = 0;
            bool g = true;
            bool p = true;
            string input = "";
            int komplinput = 0;

            while (g)
            {
                p = true;
                while (p)
                {
                    Console.Clear();
                    Console.WriteLine("Kámen, nůžky nebo papír?");
                    input = Console.ReadLine();
                    if (input == "kámen" || input == "nůžky" || input == "papír")
                    {
                        Console.WriteLine("Vybral jsi: " + input);
                        Console.WriteLine();
                        p = false;
                    }

                }

                komplinput = rnd.Next(1, 4);
                switch (komplinput + input)
                {
                    case ("1nůžky"):
                        Console.WriteLine("Kompjůtr dal kámen a vyhrál");
                        kompl++;
                        break;
                    case ("1papír"):
                        Console.WriteLine("Kompjůtr hodil kámen a prohrál");
                        human++;
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
                Console.WriteLine();
                Console.WriteLine("Kompjůtr: " + kompl);
                Console.WriteLine();
                Console.WriteLine("Člověk: " + human);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pro ukončení zmáčkni ESC, pro pokračování jakoukoli jinou klávesu");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    g = false;
                }

            }
        }
    }
}
