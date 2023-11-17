using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadejte počet řádků matice:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte počet sloupců matice:");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = CreateMatrix(rows, columns);

            Console.WriteLine("\nVytvořená matice:");
            PrintMatrix(matrix);
            /*Console.WriteLine("\nProhazování prvků na diagonále:");
            ReverseDiagonal(matrix);
            PrintMatrix(matrix);
            Console.WriteLine("\nProhazování řádků:\nkterý? \n se kterým");
            SwapRows(matrix,1+ int.Parse(Console.ReadLine()),  1+int.Parse(Console.ReadLine())); 
            PrintMatrix(matrix);
            Console.WriteLine("\nProhazování sloupců:");
            SwapColumns(matrix, 1+int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())); 
            PrintMatrix(matrix);*/


            Console.WriteLine("\nZadejte číslo pro násobení matice:");
            int multiplier = int.Parse(Console.ReadLine());
            MultiplyMatrixByNumber(matrix, multiplier);
            Console.WriteLine($"\nMatice po násobení číslem {multiplier}:");
            PrintMatrix(matrix);
            Console.ReadKey();
            int[,] transposedMatrix = TransposeMatrix(matrix);
            Console.WriteLine("\nTransponovaná matice:");
            PrintMatrix(transposedMatrix);
            Console.ReadKey();
            Console.WriteLine("\nSčítání dvou matic:");
            Console.ReadKey();
            int[,] matrixA = CreateMatrix(rows, columns);
            int[,] matrixB = CreateMatrix(rows, columns);
            Console.WriteLine("\nMatice A:");
            PrintMatrix(matrixA);
            Console.WriteLine("\nMatice B:");
            PrintMatrix(matrixB);
            int[,] sumMatrix = AddMatrices(matrixA, matrixB);
            Console.WriteLine("\nSoučet matic A + B:");
            PrintMatrix(sumMatrix);
            Console.WriteLine("\nNásobení dvou matic:");
            Console.ReadKey();
            Console.WriteLine("Zadejte počet sloupců matice B:");
            int columnsB = int.Parse(Console.ReadLine());
            int[,] matrixC = CreateMatrix(columns, columnsB);
            Console.WriteLine("\nMatice C:");
            PrintMatrix(matrixC);
            int[,] productMatrix = MultiplyMatrices(matrix, matrixC);
            Console.WriteLine("\nNásobení matice A (původní matice) a C:");
            PrintMatrix(productMatrix);
            Console.ReadKey();
        }

        // Vytvoření matice a*b s možností naplnění náhodnými čísly
        static int[,] CreateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Vytváříš matici, \nZadej ano pokud chceš náhodná čísla");
            if (Console.ReadLine()== "ano")
            {
                Random random = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = random.Next(1, 10);
                    }
                }
            }
            else
            {
                int count = 1;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = count++;
                    }
                }
            }

            return matrix;
        }

        // Výpis matice
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //
        static void ReverseDiagonal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (rows != columns)
            {
                Console.WriteLine("Nelze provést operaci - matice není čtvercová.");
                return;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = i + 1; j < columns; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
        }
        
        static void SwapRows(int[,] matrix, int row1, int row2)
        {
            int columns = matrix.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                int temp = matrix[row1, i];
                matrix[row1, i] = matrix[row2, i];
                matrix[row2, i] = temp;
            }
        }
       
        static void SwapColumns(int[,] matrix, int col1, int col2)
        {
            int rows = matrix.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, col1];
                matrix[i, col1] = matrix[i, col2];
                matrix[i, col2] = temp;
            }
        }
        // Násobení matice číslem
        static void MultiplyMatrixByNumber(int[,] matrix, int number)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] *= number;
                }
            }
        }

        // Transpozice matice
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] transposedMatrix = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }

            return transposedMatrix;
        }

        // Sčítání dvou matic
        static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rows = matrixA.GetLength(0);
            int columns = matrixA.GetLength(1);

            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            return result;
        }

        // Násobení dvou matic
        static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int columnsA = matrixA.GetLength(1);
            int columnsB = matrixB.GetLength(1);

            int[,] result = new int[rowsA, columnsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    for (int k = 0; k < columnsA; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return result;
        }
    }
}
