using System;
using System.Linq;

namespace _0._1_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] number = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)    
                {
                    matrix[row, col] = number[col];
                }
            }

            int leftSum = 0; 
            int rightSum = 0;

            for (int i = 0, j = size - 1;i < size; i++, j--)
            {
                leftSum += matrix[i, i];
                rightSum += matrix[j, i];
            }
            Console.WriteLine(Math.Abs(leftSum - rightSum));
        }
    }
}
