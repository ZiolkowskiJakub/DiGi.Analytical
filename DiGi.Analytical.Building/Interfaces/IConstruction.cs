namespace DiGi.Analytical.Building.Interfaces
{
    public interface IConstruction : IBuildingGuidObject, IBuildingNamedObject
    {

    }

    public interface IConstruction<TConstructable> : IConstruction where TConstructable : IConstructable
    {

    }
}
