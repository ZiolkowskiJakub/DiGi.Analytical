namespace DiGi.Analytical.Building.Interfaces
{
    public interface IConstruction : IBuildingGuidObject
    {

    }

    public interface IConstruction<TConstructable> : IConstruction where TConstructable : IConstructable
    {

    }
}
