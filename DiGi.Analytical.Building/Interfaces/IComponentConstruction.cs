namespace DiGi.Analytical.Building.Interfaces
{
    public interface IComponentConstruction : IConstruction
    {
        IStructure Structure { get; }
    }

    public interface IComponentConstruction<TConstructable> : IComponentConstruction, IConstruction<TConstructable> where TConstructable : IConstructable
    {
    }
}
