using VehiclePrototype.Models.Base;

namespace VehiclePrototype.Models;
/// <summary>
/// Represents a bus, a type of public transport vehicle.  Inherits from <see cref="PublicTransport"/>.
/// </summary>
public class Bus(string route, string schedule, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : PublicTransport(route, schedule, vehicleId, model, yearOfManufacture, color, length, width, height)
{
    /// <summary>
    /// Creates a custom clone of the bus.
    /// </summary>
    /// <returns>A new Bus object that is a custom clone of the current instance.</returns>
    public override Bus CustomClone()
    { 
        return (Bus)base.CustomClone();
    }
    /// <summary>
    /// Gets the type name of the bus.
    /// </summary>
    /// <returns>A string representing the type of vehicle ("Bus").</returns>
    public override string GetTypeName()=> this.GetType().Name;
    /// <summary>
    /// Returns a string representation of the bus, including its model, route, and schedule.
    /// </summary>
    /// <returns>A string representing the bus.</returns>
    public override string ToString()
    {
        return $"Model: {this.Model}, Route: {this.Route}, Schedule: {this.Schedule}";
    }
}