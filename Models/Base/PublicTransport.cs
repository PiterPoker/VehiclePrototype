using VehiclePrototype.Interfaces;

namespace VehiclePrototype.Models.Base;
/// <summary>
/// Abstract base class for all types of public transport vehicles.  Inherits from <see cref="Vehicle"/>.
/// </summary>
public abstract class PublicTransport(string route, string schedule, long vehicleId, string model, DateTime yearOfManufacture, string color, double length, double width, double height) 
    : Vehicle(vehicleId, model, yearOfManufacture, color, length, width, height)
{
    /// <summary>
    /// The route served by this public transport vehicle.
    /// </summary>
    public string? Route { get; set; } = route;
    /// <summary>
    /// The schedule for this public transport vehicle.
    /// </summary>
    public string? Schedule { get; set; } = schedule;
    /// <summary>
    /// Creates a custom clone of the public transport vehicle.  Note that Route and Schedule are set to null in the clone.
    /// </summary>
    /// <returns>A new PublicTransport object that is a custom clone of the current instance.</returns>
    public override PublicTransport CustomClone()
    {
        var publicTransportClone = (PublicTransport)base.CustomClone();        
        publicTransportClone.Route = null;
        publicTransportClone.Schedule = null;
        return publicTransportClone;
    }
}