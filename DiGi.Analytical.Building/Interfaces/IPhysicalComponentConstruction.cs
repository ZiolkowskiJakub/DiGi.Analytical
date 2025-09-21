namespace DiGi.Analytical.Building.Interfaces
{
    public interface IPhysicalComponentConstruction : IConstruction
    {

    }

    public interface IPhysicalComponentConstruction<TConstructable> : IPhysicalComponentConstruction, IConstruction<TConstructable> where TConstructable : IConstructable
    {

    }
}
