using VehiclePrototype.Interfaces;

namespace VehiclePrototype.Models.Base;

public abstract class Vehicle(long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : ICostumCloneable<Vehicle>
{
    public long VehicleId { get; set; } = vehicleId;
    public string? Model { get; set; } = model;
    public DateTime YearOfManufacture { get; set; } = yearOfManufacture;
    public string? Color { get; set; } = color;
    public double Length { get; set; } = length;
    public double Width { get; set; } = width;
    public double Height { get; set; } = height;

    public virtual Vehicle CostumClone()
    {
        var vehicleClone = (Vehicle)MemberwiseClone();
        vehicleClone.VehicleId = ++this.VehicleId;
        return vehicleClone;
    }

    public abstract string GetTypeName();
}