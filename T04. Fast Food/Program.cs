using System;
using System.Collections.Generic;
using System.Linq;

int foodLeft = int.Parse(Console.ReadLine());
Queue<int> ordersQueue = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Console.WriteLine(ordersQueue.Max());

while (ordersQueue.Any())
{
    int currentOrder = ordersQueue.Peek();

    if (foodLeft < currentOrder)
    {
        Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
        break;
    }

    foodLeft -= currentOrder;
    ordersQueue.Dequeue();
}

if (!ordersQueue.Any())
{
    Console.WriteLine("Orders complete");
}