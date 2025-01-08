using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] matrix = ReadJaggedArray(n);

        while (true)
        {
            string cmd = Console.ReadLine();
            string[] cmdArgs = cmd.Split(" ");
            string switchCmd = cmdArgs[0].ToLower();

            if (switchCmd == "end")
            {
                break;
            }

            int pointOne = int.Parse(cmdArgs[1]);
            int pointTwo = int.Parse(cmdArgs[2]);

            if (IsInvalidCoordinates(pointOne, pointTwo, n))
            {
                Console.WriteLine("Invalid coordinates.");
                continue;
            }

            int modifierNum = int.Parse(cmdArgs[3]);

            switch (switchCmd)
            {
                case "add":
                    matrix[pointOne][pointTwo] += modifierNum;
                    break;
                case "subtract":
                    matrix[pointOne][pointTwo] -= modifierNum;
                    break;
            }
        }

        PrintMatrix(matrix);
    }

    static bool IsInvalidCoordinates(int pointOne, int pointTwo, int n)
    {
        return pointOne < 0 || pointTwo < 0 || pointOne >= n || pointTwo >= n;
    }

    static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }

    static int[][] ReadJaggedArray(int n)
    {
        int[][] result = new int[n][];

        for (int row = 0; row < n; row++)
        {
            result[row] = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();
        }

        return result;
    }
}