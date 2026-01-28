namespace DiGi.Analytical.Building.Interfaces
{
    public interface IConstruction : IBuildingGuidObject, IBuildingNamedObject, IBuildingDescribableObject
    {
    }

    public interface IConstruction<TConstructable> : IConstruction where TConstructable : IConstructable
    {
    }
}