using System;

class ParkingSystem
{
    private string[] parkingSpots = new string[100]; // Array med 100 parkeringsplatser

    // Metod för att ta emot ett fordon och tilldela en ledig parkeringsplats
    public int ParkVehicle(string vehicle)
    {
        for (int i = 0; i < parkingSpots.Length; i++)
        {
            if (parkingSpots[i] == null)
            {
                parkingSpots[i] = vehicle;
                Console.WriteLine($"Välkommen {vehicle}! Kör till parkeringsplats {i + 1}.");
                return i + 1; // Returnera platsnumret (1-baserat)
            }
        }
        Console.WriteLine("Tyvärr, parkeringen är full.");
        return -1;
    }

    // Metod för att ta bort ett fordon från en specifik parkeringsplats
    public bool RemoveVehicle(int spotNumber)
    {
        if (spotNumber < 1 || spotNumber > parkingSpots.Length)
        {
            Console.WriteLine("Ogiltigt platsnummer.");
            return false; // Felaktigt platsnummer
        }

        int index = spotNumber - 1; // Konvertera från 1-baserat till 0-baserat index

        if (parkingSpots[index] != null)
        {
            Console.WriteLine($"{parkingSpots[index]} har lämnat parkeringsplats {spotNumber}.");
            parkingSpots[index] = null; // Ta bort fordonet genom att sätta platsen till null
            return true;
        }
        else
        {
            Console.WriteLine($"Plats {spotNumber} är redan tom.");
            return false; // Ingen bil att ta bort
        }
    }
    
 
    // Metod för att visa alla parkeringsplatser
    public void ShowParkingStatus()
    {
        for (int i = 0; i < parkingSpots.Length; i++)
        {
            if (parkingSpots[i] == null)
                Console.WriteLine($"Plats {i + 1}: Ledig");
            else
                Console.WriteLine($"Plats {i + 1}: {parkingSpots[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        ParkingSystem parkingSystem = new ParkingSystem();

        // Parkera några fordon
        parkingSystem.ParkVehicle("Car A");
        parkingSystem.ParkVehicle("Car B");
        parkingSystem.ParkVehicle("MC");

        // Visa parkeringsstatus
        Console.WriteLine("\nAktuell parkeringsstatus:");
        parkingSystem.ShowParkingStatus();

        // Ta bort ett fordon
        Console.WriteLine("\nAnge platsnumret för fordonet du vill ta bort:");
        int spotToRemove = int.Parse(Console.ReadLine());

        parkingSystem.RemoveVehicle(spotToRemove); // Ta bort fordonet från den specifika platsen

        // Visa parkeringsstatus efter borttagning
        Console.WriteLine("\nUppdaterad parkeringsstatus:");
        parkingSystem.ShowParkingStatus();
    }
}


// Metod för att ta bort ett fordon från en specifik parkeringsplats
//public bool RemoveVehicle(int spotNumber)
//{
//  if (spotNumber < 1 || spotNumber > parkingSpots.Length)
//{
//    Console.WriteLine("Ogiltigt platsnummer.");
//  return false; // Felaktigt platsnummer
//}