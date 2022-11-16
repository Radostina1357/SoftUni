using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._2_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack <int>(input);
            string commandInfo = Console.ReadLine().ToLower();

            while (commandInfo != "end")
            {
                var tokens = commandInfo.Split();
                var command = tokens[0].ToLower();
                if (command == "add")
                {
                    int num1 = int.Parse(tokens[1]);
                    int num2 = int.Parse(tokens[2]);
                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (command == "remove")
                {
                    int removeNum = int.Parse(tokens[1]);

                    if (removeNum <= stack.Count)
                    {
                        for (int i = 0; i < removeNum; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                commandInfo = Console.ReadLine().ToLower();
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
