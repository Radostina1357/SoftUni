using System;
using System.Linq;

namespace _0._5_SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsSize = 2;
            int colsSize = 2;

            string[] sizes = Console.ReadLine().Split(", ");

            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            int[,] matrix = new int[rows,cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int maxSum = 0;
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < rows - rowsSize + 1; row++)
            {
                for (int col = 0; col < cols - colsSize + 1; col++)
                {
                    int sum = 0;

                    sum += matrix[row,col];
                    sum += matrix[row + 1,col];
                    sum += matrix[row,col + 1];
                    sum += matrix[row + 1,col + 1];

                    if (sum > maxSum)
                    {
                        startRow = row;
                        startCol = col;
                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine($"{matrix[startRow,startCol]} {matrix[startRow, startCol + 1]}");
            Console.WriteLine($"{matrix[startRow + 1, startCol]} {matrix[startRow + 1, startCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
