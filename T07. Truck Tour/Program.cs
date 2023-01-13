using System;
using System.Collections.Generic;
using System.Linq;

Queue<PetrolStation> petrolStations = new Queue<PetrolStation>();
int n = int.Parse(Console.ReadLine());
int tank = 0;

bool isSucceed = true;


InitialiseStations(petrolStations, n);

for (int i = 0; i < n; i++)
{
    foreach (var petrolStation in petrolStations)
    {
        if (petrolStation.PetrolAmount + tank <= petrolStation.Distance)
        {
            isSucceed = false;
            break;
        }
        tank += petrolStation.PetrolAmount - petrolStation.Distance;
    }

    if (isSucceed)
    {
        Console.WriteLine(i);
        break;
    }
    else
    {
        tank = 0;
        var moveStation = petrolStations.Dequeue();
        petrolStations.Enqueue(moveStation);
        isSucceed = true;
    }
}



void InitialiseStations(Queue<PetrolStation> queue , int count)
{
    for (int i = 0; i < count; i++)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int amount = input[0];
        int distance = input[1];

        PetrolStation newStation = new PetrolStation(amount, distance);

        queue.Enqueue(newStation);
    }
}


class PetrolStation
{
    public PetrolStation(int amount, int distance)
    {
        PetrolAmount = amount;
        Distance = distance;
    }


    public int PetrolAmount;
    public int Distance;

}
