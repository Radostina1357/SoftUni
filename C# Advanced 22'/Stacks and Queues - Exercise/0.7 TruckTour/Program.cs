using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] pumpsData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(pumpsData);
            }
            for (int i = 0; i < n; i++)
            {

                bool successfulTour = true;
                int fuel = 0;

                for (int j = 0; j < n; j++)
                {
                    int[] pumpData = pumps.Dequeue();
                    pumps.Enqueue(pumpData);

                    fuel += pumpData[0];
                    int distanceToPass = pumpData[1];

                    if (distanceToPass > fuel)
                    {
                        successfulTour = false;
                    }

                    fuel -= distanceToPass;
                }

                if (successfulTour)
                {
                    Console.WriteLine(i);

                    break;
                }

                pumps.Enqueue(pumps.Dequeue());
            }

        }
    }
}
