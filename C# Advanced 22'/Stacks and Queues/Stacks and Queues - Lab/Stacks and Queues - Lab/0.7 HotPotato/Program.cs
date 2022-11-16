using System;
using System.Collections;
using System.Collections.Generic;

namespace _0._7_HotPotato
{
    class Program
    {
        private static object queue;

        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(kids);
            int count = 1;
            while (queue.Count > 1)
            {
                string currentKid = queue.Dequeue();
                if (count == number)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    count = 1;
                    continue;
                }
                count++;
                queue.Enqueue(currentKid);
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
