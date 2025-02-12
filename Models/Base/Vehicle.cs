using VehiclePrototype.Interfaces;

namespace VehiclePrototype.Models.Base;
/// <summary>
/// Abstract base class for all vehicle types.  Provides common properties and cloning functionality.
/// </summary>
public abstract class Vehicle(long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : ICustomCloneable<Vehicle>, ICloneable
{
    /// <summary>
    /// Unique identifier for the vehicle.
    /// </summary>
    public long VehicleId { get; set; } = vehicleId;
    /// <summary>
    /// Model of the vehicle.
    /// </summary>
    public string? Model { get; set; } = model;
    /// <summary>
    /// Year of manufacture of the vehicle.
    /// </summary>
    public DateTime YearOfManufacture { get; set; } = yearOfManufacture;
    /// <summary>
    /// Color of the vehicle.
    /// </summary>
    public string? Color { get; set; } = color;
    /// <summary>
    /// Length of the vehicle in unspecified units.
    /// </summary>
    public double Length { get; set; } = length;
    /// <summary>
    /// Width of the vehicle in unspecified units.
    /// </summary>
    public double Width { get; set; } = width;
    /// <summary>
    /// Height of the vehicle in unspecified units.
    /// </summary>
    public double Height { get; set; } = height;
    /// <summary>
    /// Creates a custom clone of the vehicle.  Increments the VehicleId.
    /// </summary>
    /// <returns>A new Vehicle object that is a custom clone of the current instance.</returns>
    public virtual Vehicle CustomClone()
    {
        var vehicleClone = (Vehicle)MemberwiseClone();
        vehicleClone.VehicleId = ++this.VehicleId;
        return vehicleClone;
    }
    /// <summary>
    /// Creates a shallow clone of the vehicle.
    /// </summary>
    /// <returns>A shallow copy of the current Vehicle object.</returns>
    public virtual object Clone()
    {
        return this.MemberwiseClone();
    }
    /// <summary>
    /// Gets the type name of the vehicle.
    /// </summary>
    /// <returns>A string representing the type of vehicle.</returns>
    public abstract string GetTypeName();
}