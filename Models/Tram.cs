using VehiclePrototype.Models.Base;

namespace VehiclePrototype.Models;

public class Tram(int numCarriages, string route, string schedule, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : PublicTransport(route, schedule, vehicleId, model, yearOfManufacture, color, length, width, height)
{
    public int NumCarriages { get; set; } = numCarriages;

    public override Tram CostumClone()
    {
         return (Tram)base.CostumClone();
    }

    public override string GetTypeName()=> this.GetType().Name;
    public override string ToString()
    {
        return $"Model: {this.Model}, Route: {this.Route}, Schedule: {this.Schedule}";
    }
}