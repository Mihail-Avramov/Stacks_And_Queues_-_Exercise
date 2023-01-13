using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> clothesStack = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int rackCapacity = int.Parse(Console.ReadLine());

int rackUsed = 1;
int arrangedClothes = 0;

while (clothesStack.Any())
{
    int currentClothe = clothesStack.Peek();

    if (arrangedClothes + currentClothe <= rackCapacity)
    {
        arrangedClothes += currentClothe;
        clothesStack.Pop();
    }
    else
    {
        arrangedClothes = 0;
        rackUsed ++;
    }
}

Console.WriteLine(rackUsed);