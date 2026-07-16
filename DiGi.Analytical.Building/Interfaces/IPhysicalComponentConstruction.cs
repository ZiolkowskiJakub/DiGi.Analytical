namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for constructions that define physical building components.
    /// </summary>
    public interface IPhysicalComponentConstruction : IConstruction
    {
    }

    /// <summary>
    /// Interface for physical component constructions associated with a specific constructable type.
    /// </summary>
    /// <typeparam name="TConstructable">The type of the constructable element.</typeparam>
    public interface IPhysicalComponentConstruction<TConstructable> : IPhysicalComponentConstruction, IConstruction<TConstructable> where TConstructable : IConstructable
    {
    }
}