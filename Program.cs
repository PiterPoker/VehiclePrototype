using System;
using VehiclePrototype.Models;
using VehiclePrototype.Models.Base;

namespace VehiclePrototype;
/// <summary>
/// Main program class demonstrating vehicle cloning.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the program. Creates several vehicle instances, clones them, and displays the original and cloned objects.
    /// </summary>
    /// <param name="args">Command-line arguments (not used).</param>
    public static void Main(string[] args)
    {
        // Create instances of different vehicle types
        var bus = new Bus(
            route: "10A",
            schedule: "6:00 AM - 10:00 PM",
            vehicleId: 1001,
            model: "MAN Lion's City",
            yearOfManufacture: new DateTime(2021, 1, 1),
            color: "Red",
            length: 12.0,
            width: 2.55,
            height: 3.2
        );


        var trolleybus = new Trolleybus(
            powerSource: "Electric",
            route: "5",
            schedule: "6:00 AM - 11:00 PM",
            vehicleId: 2001,
            model: "Škoda 27Tr",
            yearOfManufacture: new DateTime(2020, 5, 1),
            color: "Green",
            length: 18.0,
            width: 2.55,
            height: 3.3
        );


        var tram = new Tram(
            numCarriages: 4,
            route: "3",
            schedule: "5:00 AM - 12:00 AM",
            vehicleId: 3001,
            model: "Siemens Avenio",
            yearOfManufacture: new DateTime(2019, 9, 1),
            color: "Blue",
            length: 32.0,
            width: 2.65,
            height: 3.5
        );

        var taxi = new Taxi(
            driverName: "John Doe",
            isAvailable: true,
            vehicleId: 4001,
            model: "Toyota Prius",
            yearOfManufacture: new DateTime(2022, 1, 1),
            color: "Yellow",
            length: 4.5,
            width: 1.75,
            height: 1.5
        );

        // Clone the vehicles and modify the clones
        var clonedBus = bus.CustomClone();
        clonedBus.Route = "25B";
        clonedBus.Schedule = "5:00 AM - 11:00 PM";

        var clonedTrolleybus = (Trolleybus)trolleybus.Clone(); //Note:  Using Clone() here instead of CustomClone()
        clonedTrolleybus.Route = "7";
        clonedTrolleybus.Schedule = "6:00 AM - 10:00 PM";

        var clonedTram = tram.CustomClone();
        clonedTram.Route = "2";
        clonedTram.Schedule = "5:30 AM - 12:30 AM";

        var clonedTaxi = taxi.CustomClone();
        clonedTaxi.DriverName = "Jane Smith";
        clonedTaxi.IsAvailable = false;

        // Display the original and cloned vehicles
        ShowResult(taxi, clonedTaxi);     
        ShowResult(bus, clonedBus);
        ShowResult(trolleybus, clonedTrolleybus);
        ShowResult(tram, clonedTram);        
    }

    /// <summary>
    /// Displays the original and cloned vehicle information to the console.
    /// </summary>
    /// <param name="original">The original vehicle.</param>
    /// <param name="cloned">The cloned vehicle.</param>
    private static void ShowResult(Vehicle original, Vehicle cloned)
    {
        Console.WriteLine($"Original {original.GetTypeName()}:");
        Console.WriteLine(original.ToString());
        Console.WriteLine($"Cloned {cloned.GetTypeName()}:");
        Console.WriteLine(cloned.ToString());
    }

}
