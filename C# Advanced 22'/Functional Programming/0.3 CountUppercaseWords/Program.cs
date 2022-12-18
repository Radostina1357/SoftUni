using System;

namespace _0._3_CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startWithUpperCase = w => char.IsUpper(w[0]);

            Console.WriteLine(string.Join(Environment.NewLine, Array
                .FindAll(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries), startWithUpperCase)));
        }
    }
}
