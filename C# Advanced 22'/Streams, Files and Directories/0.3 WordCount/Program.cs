using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        { // TODO: write your code here…
            using var words = new StreamReader(wordsFilePath);
            using var reader = new StreamReader(textFilePath);
            using var writer = new StreamWriter(outputFilePath);

            var wordsToCount = words.ReadLine().Split();
            var dictionaryWords = new Dictionary<string, int>();

            foreach (var word in wordsToCount)
            {
                dictionaryWords.Add(word, 0);
            }

            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(new string[] { ".", "-", ", ", " " }, System.StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in line)
                {
                    if (dictionaryWords.ContainsKey(word.ToLower())) 
                    {
                        dictionaryWords[word.ToLower()]++;
                    }
                }
            }
            PrintOutput(dictionaryWords, writer);
        }

        private static void PrintOutput(Dictionary<string, int> dictionaryWords, StreamWriter writer)
        {
            foreach (var (word, count) in dictionaryWords.OrderByDescending(x=> x.Value))
            {
                writer.WriteLine($"{word} - {count}");
            }
        }
    }
}
