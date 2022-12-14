using System;
using System.Collections.Generic;

namespace _0._7_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(",", StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                string number = tokens[1];

                if (direction == "IN")
                {
                    if (!parking.Contains(number))
                    {
                        parking.Add(number);
                    }
                }
                else
                {
                    parking.Remove(number);
                }

                command = Console.ReadLine();
            }
            if (parking.Count > 0)
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
