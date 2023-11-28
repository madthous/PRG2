using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlgr
{
    internal class Program
    {
        class Human
        {
            public string name;
            public string eyecolor;
            public string haircolor;
            public double weight;
            public double height;
            public int age;

            public void PrintCharacteristics()
            {
                Console.WriteLine($"{name} má {age} let, měří {height} m, váží {weight} kg, {eyecolor} oči, {haircolor} vlasy.");
            }
            public double BMI()
            {
                double BMI = weight/(height*height);
                return BMI;
            }
        }
        
        
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.name = "Karel";
            human1.eyecolor = "blue";
            human1.haircolor = "blonde";
            human1.weight = 79.45444564648465;
            human1.height = 1.78169845356454;
            human1.age = 26;

            human1.PrintCharacteristics();
            double bmi = human1.BMI();
            Console.WriteLine($"{human1.name} má BMI:{bmi}");
            Console.ReadKey();
        }
    }
}
