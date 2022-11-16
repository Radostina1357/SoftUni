using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _0._8_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>(); 
            int count = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            string car = cars.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
