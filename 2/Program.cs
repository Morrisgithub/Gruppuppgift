using System;
using System.Collections.Generic;

class program
{


    // Parkeringsplatser
    static List<string>[] parkingSpots = new List<string>[101];

    static void Main(string[] args)
    {

        for (int i = 0; i < parkingSpots.Length; i++)
        {
            parkingSpots[i] = new List<string>();  // Skapar en lista för varje parkeringsruta
        }

    }
  }


// Anropa metoden ParkVehicle

Console.ReadLine();

void ParkVehicle()
{

    Console.Write("Ange registreringsnummer: ");
    string Regnummer = Console.ReadLine();

    // Om inget registreringsnummer har angetts
    if (string.IsNullOrWhiteSpace(Regnummer))
    {
        Console.WriteLine("Inget registreringsnummer angivet.");
        return;
    }


    if (Regnummer.StartsWith("MC") || Regnummer.StartsWith("CAR"))
    {
        Console.WriteLine("Registreringsnumret är giltigt.");

        // Hitta en ledig plats för att parkera fordonet
        for (int i = 0; i < parkingSpots.Length; i++)
        {

            if (parkingSpots[i].Count == 0)
            {
                parkingSpots[i].Add(Regnummer);  // Parkera fordonet
                Console.WriteLine($"Fordonet har parkerats på plats {i + 1}.");
                return;
            }
        }


        Console.WriteLine("Det finns ingen ledig parkeringsplats.");
    }
    else
    {
        Console.WriteLine("Var vänlig att ge ett giltigt regnummer.");
    }
}
///////////////////////////////////////////////////////////////////////////////////////////////////
{
    Console.Write("Ange ett regnummer: ");
    string regNumber = Console.ReadLine();

    int currentSpot = MoveVehicle (regNumber);
    if (currentSpot == -1)
    {
        Console.WriteLine("Fordonet kunde inte hittas.");
        return;
    }

    Console.Write("Ange ny platsnummer (1-100): ");
    if (int.TryParse(Console.ReadLine(), out int newSpot) && newSpot >= 1 && newSpot <= 100)
    {
        newSpot--;

        if (string.IsNullOrEmpty(parkingSpots[newSpot]))
        {
            parkingSpots[newSpot] = parkingSpots[currentSpot];
            parkingSpots[currentSpot] = null;
            Console.WriteLine("Fordonet har flyttats till plats {0}.", newSpot + 1);
        }
        else
        {
            Console.WriteLine("Den nya platsen är upptagen.");
        }
    }
    else
    {
        Console.WriteLine("Ogiltigt platsnummer.");
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////
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
///////////////////////////////////////////////////////////////////////////////////////////

{
    Console.Write("Ange registreringsnummer att söka: ");
    string regNumber = Console.ReadLine();

    for (int i = 0; i < parkingSpots.Length; i++)
    {
        if (parkingSpots[i].Contains(regNumber))
        {
            Console.WriteLine($"Fordonet finns på plats {i + 1}.");
            return;
        }
    }

    Console.WriteLine("Fordonet kunde inte hittas.");
}

static void ShowMenu()
{
    Console.WriteLine("\n--- Parkeringssystem ---");
    Console.WriteLine("1. Ta emot fordon");
    Console.WriteLine("2. Flytta fordon");
    Console.WriteLine("3. Uthämta fordon");
    Console.WriteLine("4. Sök efter fordon");
    Console.WriteLine("5. Visa parkeringsstatus");
    Console.WriteLine("6. Avsluta");
    Console.Write("Vänligen välj ett alternativ: ");
}
Console.WriteLine("tryck på ett tagent för att ta bort rutan");
Console.ReadKey();





//Console.Write("Enter the spot number of the vehicle to remove:");
//string spotNumber = Console.ReadLine();
//{

//}

