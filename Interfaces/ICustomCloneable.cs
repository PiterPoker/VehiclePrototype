namespace VehiclePrototype.Interfaces;
/// <summary>
/// Defines a method for creating a custom clone of an object.
/// </summary>
/// <typeparam name="T">The type of object being cloned. Must be a reference type (class).</typeparam>
public interface ICustomCloneable<T>
    where T : class
{
    /// <summary>
    /// Creates a custom clone of the object.
    /// </summary>
    /// <returns>A custom clone of the object.</returns>
    T CustomClone();
}