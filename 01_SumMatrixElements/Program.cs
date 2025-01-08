using System;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine()
                                    .Split(", ")
                                    .Select(int.Parse)
                                    .ToArray();

            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            int[,] matrix = new int[rows, cols];

            int sumOfElements = 0;

            for (int column = 0; column < matrix.GetLength(0); column++)
            {
                int[] matrixValue = Console.ReadLine()
                                    .Split(", ")
                                    .Select(int.Parse)
                                    .ToArray();
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    int currentValue = matrixValue[row];
                    matrix[column, row] = currentValue;
                    sumOfElements += currentValue;
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sumOfElements);
        }
    }
}