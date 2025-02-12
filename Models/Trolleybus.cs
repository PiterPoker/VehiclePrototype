using VehiclePrototype.Models.Base;

namespace VehiclePrototype.Models;
/// <summary>
/// Represents a trolleybus, a type of public transport vehicle. Inherits from <see cref="PublicTransport"/>.
/// </summary>
public class Trolleybus(string powerSource, string route, string schedule, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : PublicTransport(route, schedule, vehicleId, model, yearOfManufacture, color, length, width, height)
{
    /// <summary>
    /// The power source of the trolleybus (e.g., "Electricity").
    /// </summary>
    public string? PowerSource { get; set; } = powerSource;
    /// <summary>
    /// Creates a custom clone of the trolleybus.
    /// </summary>
    /// <returns>A new Trolleybus object that is a custom clone of the current instance.</returns>
    public override Trolleybus CustomClone()
    {        
        return (Trolleybus)base.CustomClone();
    }
    /// <summary>
    /// Gets the type name of the trolleybus.
    /// </summary>
    /// <returns>A string representing the type of vehicle ("Trolleybus").</returns>
    public override string GetTypeName()=> this.GetType().Name;
    /// <summary>
    /// Returns a string representation of the trolleybus, including its model, route, schedule, and power source.
    /// </summary>
    /// <returns>A string representing the trolleybus.</returns>
    public override string ToString()
    {
        return $"Model: {this.Model}, Route: {this.Route}, Schedule: {this.Schedule}";
    }
}