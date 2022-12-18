using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputPath, string outputPath)
        { // TODO: write your code here…
            using (StreamReader reader = new StreamReader(inputPath))
            {
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    int row = 1;
                    string line = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        writer.WriteLine($"{row}. {line} ");
                        row++;
                        line = reader.ReadLine();
                    }
                }

            }
        }
    }
}
