using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._8_SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> party = new HashSet<string>();

            string guest = Console.ReadLine();

            while (guest != "PARTY")
            {
                if (guest.Length == 8)
                {
                    party.Add(guest);
                }
                guest = Console.ReadLine();
            }
            while (guest != "END")
            {
                party.Remove(guest);

                guest = Console.ReadLine();
            }
            Console.WriteLine(party.Count);
            Console.WriteLine(string.Join("\n", party
                .OrderByDescending(x => char.IsDigit(x[0]))));
        }
    }
}
