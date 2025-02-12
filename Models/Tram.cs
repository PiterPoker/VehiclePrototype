using VehiclePrototype.Models.Base;

namespace VehiclePrototype.Models;
/// <summary>
/// Represents a tram, a type of public transport vehicle. Inherits from <see cref="PublicTransport"/>.
/// </summary>
public class Tram(int numCarriages, string route, string schedule, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : PublicTransport(route, schedule, vehicleId, model, yearOfManufacture, color, length, width, height)
{
    /// <summary>
    /// The number of carriages in the tram.
    /// </summary>
    public int NumCarriages { get; set; } = numCarriages;
    /// <summary>
    /// Creates a custom clone of the tram.
    /// </summary>
    /// <returns>A new Tram object that is a custom clone of the current instance.</returns>
    public override Tram CustomClone()
    {
         return (Tram)base.CustomClone();
    }
    /// <summary>
    /// Gets the type name of the tram.
    /// </summary>
    /// <returns>A string representing the type of vehicle ("Tram").</returns>
    public override string GetTypeName()=> this.GetType().Name;
    /// <summary>
    /// Returns a string representation of the tram, including its model, route, schedule, and number of carriages.
    /// </summary>
    /// <returns>A string representing the tram.</returns>
    public override string ToString()
    {
        return $"Model: {this.Model}, Route: {this.Route}, Schedule: {this.Schedule}";
    }
}