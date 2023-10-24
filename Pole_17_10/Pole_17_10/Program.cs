using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayPlayground
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
                int[] numbers = new int[] { 1, 2, 3, 4, 5 };

                //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for a foreach.
                Console.WriteLine("Pole:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
                Console.WriteLine("Pole (foreach):");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }

                //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                Console.WriteLine("Suma: " + sum);

                //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
                int average = sum / numbers.Length;
                Console.WriteLine("Průměr: " + average);

                //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
                int max = numbers.Max();
                Console.WriteLine("Maximum: " + max);

                //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
                int min = numbers.Min();
                Console.WriteLine("Minimum: " + min);

                //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
                Console.Write("Zadej číslo k vyhledání: ");
                int target = int.Parse(Console.ReadLine());
                int index = Array.IndexOf(numbers, target);
                if (index != -1)
                {
                    Console.WriteLine("Číslo " + target + " bylo nalezeno na indexu " + index);
                }
                else
                {
                    Console.WriteLine("Číslo " + target + " nebylo nalezeno v poli.");
                }

                //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
                int[] rndarr = new int[100];
                Random rnd = new Random();
                for (int i = 0; i < rndarr.Length; i++)
                {
                    rndarr[i] = rnd.Next(10);
                }

                //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
                int[] counts = new int[10];
                foreach (int num in rndarr)
                {
                    counts[num]++;
                }
                for (int i = 0; i < counts.Length; i++)
                {
                    Console.WriteLine("Číslo " + i + " se vyskytuje " + counts[i] + "krát.");
                }

                //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
                int[] revarr = new int[rndarr.Length];
                for (int i = 0; i < rndarr.Length; i++)
                {
                    revarr[i] = rndarr[rndarr.Length - 1 - i];
                }

                // Zůstaňte na konci programu, dokud uživatel nezmáčkne klávesu.
                Console.ReadKey();
            }
        }
    }