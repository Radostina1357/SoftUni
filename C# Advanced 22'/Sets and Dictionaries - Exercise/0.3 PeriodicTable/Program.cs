using System;
using System.Collections.Generic;

namespace _0._3_PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicals = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                elements.UnionWith(chemicals);
            }

            Console.WriteLine(string.Join(" ", elements));  
        }
    }
}
