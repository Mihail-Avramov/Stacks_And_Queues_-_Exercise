using System;
using System.Collections.Generic;
using System.Linq;

int queryCounts = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < queryCounts; i++)
{
    int[] inputArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    int command = inputArray[0];

    switch (command)
    {
        case 1:
            int number = inputArray[1];
            stack.Push(number);
            break;
        case 2:
            if(stack.Any())
                stack.Pop();
            break;
        case 3:
            if(stack.Any())
                Console.WriteLine(stack.Max());
            break;
        case 4:
            if(stack.Any())
                Console.WriteLine(stack.Min());
            break;
    }

}

Console.WriteLine(string.Join(", ", stack));