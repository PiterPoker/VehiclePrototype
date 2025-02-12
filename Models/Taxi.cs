using VehiclePrototype.Models.Base;

namespace VehiclePrototype.Models;
/// <summary>
/// Represents a taxi, a type of vehicle. Inherits from <see cref="Vehicle"/>.
/// </summary>
public class Taxi(string driverName, bool isAvailable, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height)
        : Vehicle(vehicleId, model, yearOfManufacture, color, length, width, height)
{
    /// <summary>
    /// The name of the taxi driver.
    /// </summary>
    public string? DriverName { get; set; } = driverName;
    /// <summary>
    /// Indicates whether the taxi is currently available.
    /// </summary>
    public bool IsAvailable { get; set; } = isAvailable;
    /// <summary>
    /// Creates a custom clone of the taxi. The DriverName is set to null in the clone.
    /// </summary>
    /// <returns>A new Taxi object that is a custom clone of the current instance.</returns>
    public override Taxi CustomClone()
    {
        var taxiClone = (Taxi)base.CustomClone();
        taxiClone.DriverName = null;
        return taxiClone; 
    }
    /// <summary>
    /// Gets the type name of the taxi.
    /// </summary>
    /// <returns>A string representing the type of vehicle ("Taxi").</returns>
    public override string GetTypeName()=> this.GetType().Name;
    /// <summary>
    /// Returns a string representation of the taxi, including its model, driver name, and availability.
    /// </summary>
    /// <returns>A string representing the taxi.</returns>
    public override string ToString()
    {
        return $"Model: {this.Model}, Driver: {this.DriverName}, Is Available: {this.IsAvailable}";
    }
}