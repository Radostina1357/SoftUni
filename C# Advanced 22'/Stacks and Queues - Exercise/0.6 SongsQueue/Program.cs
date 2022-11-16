using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", "
                , StringSplitOptions.RemoveEmptyEntries).ToArray();

            var songs = new Queue<string>(input);


            while (songs.Any())
            {
                var tokens = Console.ReadLine().Split(" ",
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Play":
                        Play(songs);
                        break;
                    case "Add":
                        string addSong = string.Join(" ", tokens.Skip(1));

                        AddSong(songs, addSong, tokens);
                        break;
                    case "Show":
                        Show(songs);
                        break;
                }
            }

            Console.WriteLine($"No more songs!");
        }

        static void Show(Queue<string> songs)
        {
            Console.WriteLine(string.Join(", ", songs));
        }

        static void Play(Queue<string> songs)
        {
            songs.Dequeue();
        }
        static void AddSong(Queue<string> songs, string addSong, string[] tokens)
        {
            string song = string.Join(" ", tokens.Skip(1));
            if (!songs.Contains(song))
            {
                songs.Enqueue(song);

                return;
            }

            Console.WriteLine($"{song} is already contained!");
        }
    }
}
