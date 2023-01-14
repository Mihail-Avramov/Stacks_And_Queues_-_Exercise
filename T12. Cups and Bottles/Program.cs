using System;
using System.Collections.Generic;
using System.Linq;

Queue<int> cupsQueue = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> bottlesStack = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int wastedWater = 0;

while (cupsQueue.Any() && bottlesStack.Any())
{
    int currentCup = cupsQueue.Dequeue();
    int currentBottle = bottlesStack.Pop();
    
    currentCup -= currentBottle;

    if (currentCup <= 0)
    {
        wastedWater += Math.Abs(currentCup);
    }
    else
    {
        while (bottlesStack.Any())
        {
            currentBottle = bottlesStack.Pop();
            currentCup -= currentBottle;
            if (currentCup <= 0)
            {
                wastedWater += Math.Abs(currentCup);
                break;
            }
        }
    }
}

if (cupsQueue.Any())
{
    Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");
}
else
{
    Console.WriteLine($"Bottles: {string.Join(" ", bottlesStack)}");
}

Console.WriteLine($"Wasted litters of water: {wastedWater}");