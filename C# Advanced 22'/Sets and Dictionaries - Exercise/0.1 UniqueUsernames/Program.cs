using System;
using System.Collections.Generic;

namespace _0._1_UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string newName = Console.ReadLine();

                if (!names.Contains(newName))
                {
                    names.Add(newName);
                }
            }
            foreach (var name in names)
            {
                Console.WriteLine(string.Join(" ", name));
            }
        }
    }
}
