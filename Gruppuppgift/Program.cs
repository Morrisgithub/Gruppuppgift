using System;
using System.Numerics;

Console.WriteLine("Ange fordonstyp MC eller CAR och regnummer: ");
string Regnummer = Console.ReadLine();

Console.WriteLine();
Console.WriteLine(Regnummer);

if (Regnummer.StartsWith("MC") || (Regnummer.StartsWith("CAR")))
{
    Console.WriteLine("ssss");// kod för att säga ledig parkeringsplats
}

else
{
    Console.WriteLine("Var vänlig att ge ett giltigt regnummer.");
}
Console.WriteLine();






string[] parkingGarage = new string[100];

for (int index = 0; index < parkingGarage.Length; index++)
{
    Console.WriteLine("Plats[{0}] = {1}", index, parkingGarage[index]);
}

////////////////////////////////////////////////////////////////////////////////////////////////// Morris
{
    Console.Write("Enter the spot number of the vehicle to remove");
    string spotNumber = Console.ReadLine();
}






