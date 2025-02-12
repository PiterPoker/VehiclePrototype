using VehiclePrototype.Models.Base;

namespace VehiclePrototype.Models;

public class Bus(string route, string schedule, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : PublicTransport(route, schedule, vehicleId, model, yearOfManufacture, color, length, width, height)
{
    public override Bus CostumClone()
    { 
        return (Bus)base.CostumClone();
    }

    public override string GetTypeName()=> this.GetType().Name;
    public override string ToString()
    {
        return $"Model: {this.Model}, Route: {this.Route}, Schedule: {this.Schedule}";
    }
}