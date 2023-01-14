using System;
using System.Collections.Generic;
using System.Linq;

int greenLightTime = int.Parse(Console.ReadLine());
int safeWindowsTime = int.Parse(Console.ReadLine());
int passedCars = 0;

Queue<string> carsQueue = new Queue<string>();

string input;

while ((input = Console.ReadLine()) != "END")
{
    if (input == "green")
    {   
        int currentTimer = greenLightTime;
        string currentCar = string.Empty;
        while (currentTimer > 0 && carsQueue.Any())
        {
            currentCar = carsQueue.Dequeue();
            currentTimer -= currentCar.Length;
            passedCars++;
        }

        if (currentTimer + safeWindowsTime < 0)
        {
            char hittedChar = currentCar[currentCar.Length + currentTimer + safeWindowsTime];
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{currentCar} was hit at {hittedChar}.");
            return;
        }
        
    }
    else
    {
        carsQueue.Enqueue(input);
    }
}
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passedCars} total cars passed the crossroads.");