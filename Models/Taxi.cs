using VehiclePrototype.Models.Base;

namespace VehiclePrototype.Models;

public class Taxi(string driverName, bool isAvailable, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height)
        : Vehicle(vehicleId, model, yearOfManufacture, color, length, width, height)
{
    public string? DriverName { get; set; } = driverName;
    public bool IsAvailable { get; set; } = isAvailable;

    public override Taxi CostumClone()
    {
        var taxiClone = (Taxi)base.CostumClone();
        taxiClone.DriverName = null;
        return taxiClone; 
    }

    public override string GetTypeName()=> this.GetType().Name;
    public override string ToString()
    {
        return $"Model: {this.Model}, Driver: {this.DriverName}, Is Available: {this.IsAvailable}";
    }
}