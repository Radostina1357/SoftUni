﻿using System;
using System.Linq;

namespace _0._4_MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);

            string[,] matrix = new string[rows, cols];

            FillMatrix(matrix);

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (!ValidateCommand(command, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    string[] splitted = command.Split();
                    int row1 = int.Parse(splitted[1]);
                    int col1 = int.Parse(splitted[2]);
                    int row2 = int.Parse(splitted[3]);
                    int col2 = int.Parse(splitted[4]);

                    string firstElement = matrix[row1, col1];
                    string secondElement = matrix[row2, col2];
                    matrix[row2, col2] = firstElement;
                    matrix[row1, col1] = secondElement;

                    PrintMatrix(matrix);
                }
                command = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool ValidateCommand(string command, int rows, int cols)
        {
            string[] splitted = command.Split();

            if (splitted[0] == "swap" && splitted.Length == 5)
            {
                int row1 = int.Parse(splitted[1]);
                int col1 = int.Parse(splitted[2]);
                int row2 = int.Parse(splitted[3]);
                int col2 = int.Parse(splitted[4]);

                if (row1 >= 0 && row1 < rows
                    && col1 >= 0 && col1 < cols
                    && row2 >= 0 && row2 < rows
                    && col2 >= 0 && col2 < cols)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static void FillMatrix(string[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] number = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = number[col];
                }
            }
        }
    }
}

