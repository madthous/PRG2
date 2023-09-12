using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvyprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Aká tvoja výškav centimetroch?");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tvoja výška: " + v + "cm");*/
            Console.WriteLine("Aký diamétr v cm?");
            int r = Convert.ToInt32(Console.ReadLine());
            double S = r * r * Math.PI;
            double O = 2 * r * Math.PI;
            Console.WriteLine("Plocha: " + S + "cm^2, Obvod: " + O + "cm");
            Console.ReadKey();
        }
    }
}
