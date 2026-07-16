namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building constructions that combine GUID identification, naming, and description.
    /// </summary>
    public interface IConstruction : IBuildingGuidObject, IBuildingNamedObject, IBuildingDescribableObject
    {
    }

    /// <summary>
    /// Interface for building constructions associated with a specific constructable type.
    /// </summary>
    /// <typeparam name="TConstructable">The type of the constructable element.</typeparam>
    public interface IConstruction<TConstructable> : IConstruction where TConstructable : IConstructable
    {
    }
}