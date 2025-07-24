namespace DiGi.Analytical.Building.Interfaces
{
    public interface IStructureLayer : IBuildingSerializableObject
    {
        string Name { get; }
        double Thickness { get; }
    }
}
