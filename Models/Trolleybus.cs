using VehiclePrototype.Models.Base;

namespace VehiclePrototype.Models;
public class Trolleybus(string powerSource, string route, string schedule, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : PublicTransport(route, schedule, vehicleId, model, yearOfManufacture, color, length, width, height)
{
    public string? PowerSource { get; set; } = powerSource;

    public override Trolleybus CostumClone()
    {        
        return (Trolleybus)base.CostumClone();
    }

    public override string GetTypeName()=> this.GetType().Name;
    public override string ToString()
    {
        return $"Model: {this.Model}, Route: {this.Route}, Schedule: {this.Schedule}";
    }
}