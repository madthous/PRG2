using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
        int[,] array = new int[5, 5];
        int num = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = num;
                num++;
            }
        }
        Print2DArray(array);

        // TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
        int nRow = int.Parse(Console.ReadLine());
        PrintRow(array, nRow);

        // TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
        int nColumn = int.Parse(Console.ReadLine()); ;
        PrintColumn(array, nColumn);

        // TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
        int xFirst = 0, yFirst = 0, xSecond = 1, ySecond = 1;
        SwapElements(array, xFirst, yFirst, xSecond, ySecond);
        Print2DArray(array);

        // TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
        int nRowSwap = 2, mRowSwap = 4;
        SwapRows(array, nRowSwap, mRowSwap);
        Print2DArray(array);

        // TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
        int nColSwap = 1, mColSwap = 3;
        SwapColumns(array, nColSwap, mColSwap);
        Print2DArray(array);

        // TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
        MainDia(array);
        Print2DArray(array);

        // TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
        SecDia(array);
        Print2DArray(array);

        Console.ReadKey();
    }

    static void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void PrintRow(int[,] array, int row)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[row, j] + " ");
        }
        Console.WriteLine();
    }

    static void PrintColumn(int[,] array, int column)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine(array[i, column]);
        }
    }

    static void SwapElements(int[,] array, int x1, int y1, int x2, int y2)
    {
        int temp = array[x1, y1];
        array[x1, y1] = array[x2, y2];
        array[x2, y2] = temp;
    }

    static void SwapRows(int[,] array, int n, int m)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SwapElements(array, n, j, m, j);
        }
    }

    static void SwapColumns(int[,] array, int n, int m)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            SwapElements(array, i, n, i, m);
        }
    }

    static void MainDia(int[,] array)
    {
        int size = array.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                SwapElements(array, i, j, j, i);
            }
        }
    }

    static void SecDia(int[,] array)
    {
        int size = array.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                SwapElements(array, i, j, size - j - 1, size - i - 1);
            }
        }
    }
}