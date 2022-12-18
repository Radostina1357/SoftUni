using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);

        }
        public static void MergeTextFiles(string firstInputFilePath, 
            string secondInputFilePath, string outputFilePath)
        { // TODO: write your code here… } } }

            using var first = new StreamReader(firstInputFilePath);
            using var second = new StreamReader(secondInputFilePath);
            using var writer = new StreamWriter(outputFilePath);

            var max = (Math.Max(firstInputFilePath.Length, secondInputFilePath.Length));

            for (int i = 0, j= 0; i <= (Math.Max(firstInputFilePath.Length, secondInputFilePath.Length)); i++, j++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                {
                    writer.WriteLine(first.ReadLine());
                }
                else
                {
                    writer.WriteLine(second.ReadLine());
                }
            }
        }
    }
}

