using VehiclePrototype.Interfaces;

namespace VehiclePrototype.Models.Base;

public abstract class PublicTransport(string route, string schedule, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : Vehicle(vehicleId, model, yearOfManufacture, color, length, width, height)
{
    public string? Route { get; set; } = route;
    public string? Schedule { get; set; } = schedule;

    public override PublicTransport CostumClone()
    {
        var publicTransportClone = (PublicTransport)base.CostumClone();        
        publicTransportClone.Route = null;
        publicTransportClone.Schedule = null;
        return publicTransportClone;
    }
}