using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cojavimdedicnost
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public int endangerement;
        }
        class Dog:Animal
        {
            public int numberOfPups;
            public string race;
        }
        class Gato:Animal
        {
            public bool mlikozrout;
            public string furClr;

        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.name = "Boban";
            dog.race = "A";
            dog.age = 10;
            dog.endangerement = 0;
            dog.numberOfPups = 4;
            Console.WriteLine($"Hento {dog.name}, je to {dog.age} roku stary");
            Gato elgato = new Gato();
            elgato.name = "Pičomňau";
            elgato.age = 7;
            elgato.endangerement = 0;
            elgato.mlikozrout = true;
            elgato.furClr = "Bila";
            Console.WriteLine($"Hento {elgato.name}, je to {elgato.age} roku stary");


            Console.ReadKey();
        }
    }
}
