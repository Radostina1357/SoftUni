using System;

namespace _0._7_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] paskalTriangle = new long[n][];

            for (int row = 0; row < n; row++)
            {
                paskalTriangle[row] = new long[row + 1];

                for (int col = 0; col < paskalTriangle[row].Length; col++)
                {
                    if (row == 0)
                    {
                        paskalTriangle[row][col] = 1;
                        continue;
                    }
                    long currentValue = 0;
                    if (col > 0)
                    {
                        currentValue += paskalTriangle[row - 1][col - 1];
                    }
                    if (paskalTriangle[row].Length - 1 > col)
                    {
                        currentValue += paskalTriangle[row - 1][col];
                    }
                    paskalTriangle[row][col] = currentValue;
                }
            }
            for (int row = 0; row < paskalTriangle.Length; row++)
            {
                for (int col = 0; col < paskalTriangle[row].Length; col++)
                {
                    Console.Write($"{paskalTriangle[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
