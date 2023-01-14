using System;
using System.Collections.Generic;
using System.Linq;

int bulletPrice = int.Parse(Console.ReadLine());
int gunBarrelSize = int.Parse(Console.ReadLine());

Stack<int> bulletsStack = new Stack<int>(Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

Queue<int> locksQueue = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int intelligence = int.Parse(Console.ReadLine());

int reloadingCounter = 0;
int totalShoots = 0;

while (bulletsStack.Any() && locksQueue.Any())
{
    int currentBullet = bulletsStack.Pop();
    int currentLock = locksQueue.Peek();
    reloadingCounter++;
    totalShoots++;
    
    if (currentLock >= currentBullet)
    {
        locksQueue.Dequeue();
        Console.WriteLine("Bang!");
    }
    else
    {
        Console.WriteLine("Ping!");
    }

    if (reloadingCounter == gunBarrelSize && bulletsStack.Any())
    {
        reloadingCounter = 0;
        Console.WriteLine("Reloading!");
    }
}

if (locksQueue.Count == 0)
{
    int moneyEarned = intelligence - bulletPrice * totalShoots;
    Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${moneyEarned}");
}
else
{
    Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
}