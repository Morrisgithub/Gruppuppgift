using System;
using System.ComponentModel;

List<string>[] parkingSpots = new List<string>[101];
for (int i = 0; i < parkingSpots.Length; i++)
{
    parkingSpots[i] = new List<string>();  // Skapar en lista för varje parkeringsruta
}
removeVehicle();
void removeVehicle()
{
    string regNumber = "CAR111";

    Console.Write("Enter the spot number of the vehicle to remove:");
    string spotNumber = Console.ReadLine();

    Console.WriteLine("Invalid registration number");


    for (int i = 1; i < parkingSpots.Length; i--)
    {


        if (parkingSpots[i].Count == 1)
        {
            parkingSpots[i].Remove(regNumber);
            Console.WriteLine("The vehicle is removed from the parkingspots");
            break;
        }

    }
}
Console.WriteLine("tryck på ett tagent för att ta bort rutan");
Console.ReadKey();
//Console.Write("Enter the spot number of the vehicle to remove:");
//string spotNumber = Console.ReadLine();
//{

//}

