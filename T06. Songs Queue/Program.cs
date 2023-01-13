using System;
using System.Collections.Generic;

Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));

while (songsQueue.Count > 0)
{
    string[] input = Console.ReadLine().Split(" ", 2);
    string command = input[0];

    switch (command)
    {
        case "Play":
            songsQueue.Dequeue();
            break;
        case "Add":
            string song = input[1];
            if (songsQueue.Contains(song))
            {
                Console.WriteLine($"{song} is already contained!");
            }
            else
            {
                songsQueue.Enqueue(song);
            }
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songsQueue));
            break;
    }
}
Console.WriteLine("No more songs!");