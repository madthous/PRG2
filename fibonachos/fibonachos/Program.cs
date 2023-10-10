using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš tu přirozené číslo pro které chceš vypočítati faktoriál:");
            long na = long.Parse(Console.ReadLine());
            

            long factorial = Factorial(na); // Prvni zavolani pro vypocet faktorialu, ulozeni do promenne factorial.

            Console.WriteLine("Napiš tu přirozené číslo určující pořadí ve Fibonacciho posloupnosti:");
            long nb = long.Parse(Console.ReadLine());
            
            long fibonacci = Fibonacci(nb); // Prvni zavolani pro vypocet Fibonacciho posloupnosti, ulozeni do promenne fibonacci.

            Console.WriteLine($"Pro cislo {na} je faktorial {factorial} a {nb}. prvek Fibonacciho posloupnosti je {fibonacci}"); // Vypsani vysledku uzivateli.
            Console.ReadKey();
        }

        static long Factorial(long na)
        {
            // TODO: Urci ukoncovaci podminku pro faktorial a zavolej Factorial zevnitr se spravnym parametrem / vypoctem.
            if (na == 1) return 1; 
            return na*Factorial(na-1); // TODO: Uprav, aby Factorial vracel spravnou hodnotu.
        }

        static long Fibonacci(long nb)
        {

            // TODO: Urci ukoncovaci podminku pro Fibonacciho a zavolej Fibonacci zevnitr se spravnym parametrem / vypoctem.
            if (nb <= 1)
            {
                Console.WriteLine(nb);
                return nb;
            }
            else
            {
                Console.WriteLine("hm" +nb);

                return Fibonacci(nb-1)+Fibonacci(nb-2);
            }
             // TODO: Uprav, aby Fibonacci vracel spravnou hodnotu.
        }
    }
}
