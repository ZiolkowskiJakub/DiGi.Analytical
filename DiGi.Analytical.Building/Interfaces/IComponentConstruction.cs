namespace DiGi.Analytical.Building.Interfaces
{
    public interface IComponentConstruction : IConstruction
    {

    }

    public interface IComponentConstruction<TConstructable> : IComponentConstruction, IConstruction<TConstructable> where TConstructable : IConstructable
    {

    }
}
