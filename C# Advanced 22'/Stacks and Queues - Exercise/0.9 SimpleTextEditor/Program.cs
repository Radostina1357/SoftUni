using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var text = new StringBuilder();

            var memory = new Stack<string>();
            memory.Push(string.Empty);

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                string cmd = tokens[0];

                if (cmd == "1")
                {
                    string arg = tokens[1];

                    text.Append(arg);
                    memory.Push(text.ToString());
                }
                else if (cmd == "2")
                {
                    int chars = int.Parse(tokens[1]);

                    text = text.Remove(text.Length - chars, chars);
                    memory.Push(text.ToString());
                }
                else if (cmd == "3")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index <= text.Length)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }
                else if (cmd == "4")
                {
                    memory.Pop();
                    string newText = memory.Peek();

                    text = new StringBuilder(newText);
                }
            }
        }
    }
}
