using System;
using System.Linq;

namespace _0._4_AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> addVAT = x => (decimal.Parse(x) * 1.2M).ToString("F2");

            Console.WriteLine(string.Join(Environment.NewLine,
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(addVAT)));
        }
    }
}
