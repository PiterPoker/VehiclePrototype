namespace VehiclePrototype.Interfaces;
public interface ICostumCloneable<T>
    where T : class
{
    T CostumClone();
}