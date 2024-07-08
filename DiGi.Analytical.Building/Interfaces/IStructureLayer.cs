namespace DiGi.Analytical.Building.Interfaces
{
    public interface IStructureLayer : IBuildingObject
    {
        string Name { get; }
        double Thickness { get; }
    }
}
