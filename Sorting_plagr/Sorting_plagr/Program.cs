﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_plagr
{
    internal class Program
    {
        //Pokud si nejsi jistý/á, co dělat, podívej se do prezentace, na videa na YT, co jsem doporučoval, googluj a nebo mě zavolej a já ti poradím.

        static int[] BubbleSort(int[] array)
        {
            int[] sortedArray = (int[])array.Clone(); // Řaď v tomto poli, ve kterém je výchoze zkopírováno všechno ze vstupního pole.
            int l = sortedArray.Length;
            int x;
            for (int i = 0; i < l-1; i++)
            {
                for (int j = 0; j < l - i -1; j++)
                {
                    if (sortedArray[j] > sortedArray[j+1])
                    {
                        x = sortedArray[j];
                        sortedArray[j] = sortedArray[j+1];
                        sortedArray[j+1] = x;
                    }
                }
            }
            return sortedArray;
        }

        static int[] SelectionSort(int[] array)
        {
            int[] sortedArray = (int[])array.Clone(); // Řaď v tomto poli, ve kterém je výchoze zkopírováno všechno ze vstupního pole.
            int l = sortedArray.Length;
            int min;
            int x;
            for (int i = 0; i < l-1; i++)
            {
                min = i;
                for (int j = i +1; j < l; j++)
                {
                    if (sortedArray[j] < sortedArray[min])
                    {
                        min = j;
                    }
                }
                x = sortedArray[min];
                sortedArray[min] = sortedArray[i];
                sortedArray[i] = x;
            }
            return sortedArray;
        }

        static int[] InsertionSort(int[] array)
        {
            int[] sortedArray = (int[])array.Clone(); // Řaď v tomto poli, ve kterém je výchoze zkopírováno všechno ze vstupního pole.
            int l = array.Length;
            int n;
            int x;
            for (int i = 0; i < l; i++)
            {
                n = sortedArray[i];
                x = i - 1;
                while (x >= 0 && sortedArray[x] > n)
                {
                    sortedArray[x + 1] = sortedArray[x];
                    x--;
                }
                sortedArray[x + 1] = n;
            }
            return sortedArray;
        }

        static int[] MergeSort(int[] array)
        {
            int[] sortedArray = (int[])array.Clone(); // Řaď v tomto poli, ve kterém je výchoze zkopírováno všechno ze vstupního pole.
            int l = array.Length;

            int n;
            int x;
            
            return sortedArray;
        }

        static int[] QuickSort(int[] array)
        {
            int[] sortedArray = (int[])array.Clone(); // Řaď v tomto poli, ve kterém je výchoze zkopírováno všechno ze vstupního pole.
            int l = array.Length;
            int n;
            int x;
            
            return sortedArray;
        }

        //Naplní pole náhodnými čísly mezi 1 a velikostí pole.
        static void FillArray(int[] array)
        {
            Random rng = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(1, array.Length + 1);
            }
        }

        //Vypíše pole do konzole.
        static void WriteArrayToConsole(int[] array, string arrayName)
        {
            Console.Write(arrayName + " = [");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]\n\n");
        }

        //Zavolá postupně Bubble sort, Selection sort a Insertion sort pro zadané pole (a vypíše jeho jméno pro přehlednost)
        static void SortArray(int[] array, string arrayName)
        {
            Console.WriteLine($"Řadím {arrayName}:");
            int[] sortedArray;

            sortedArray = BubbleSort(array);
            WriteArrayToConsole(sortedArray, arrayName + " seřazené Bubble sortem");

            sortedArray = SelectionSort(array);
            WriteArrayToConsole(sortedArray, arrayName + " seřazené Selection sortem");

            sortedArray = InsertionSort(array);
            WriteArrayToConsole(sortedArray, arrayName + " seřazené Insertion sortem");

            sortedArray = MergeSort(array);
            WriteArrayToConsole(sortedArray, arrayName + " seřazené Insertion sortem");

            sortedArray = QuickSort(array);
            WriteArrayToConsole(sortedArray, arrayName + " seřazené Insertion sortem");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] smallArray = new int[10];
            FillArray(smallArray);

            int[] mediumArray = new int[100];
            FillArray(mediumArray);

            int[] largeArray = new int[1000];
            FillArray(largeArray);

            WriteArrayToConsole(smallArray, "Malé pole");
            SortArray(smallArray, "Malé pole");

            WriteArrayToConsole(mediumArray, "Střední pole");
            SortArray(mediumArray, "Střední pole");

            WriteArrayToConsole(largeArray, "Velké pole");
            SortArray(largeArray, "Velké pole");

            Console.ReadKey();
        }
    }
}
