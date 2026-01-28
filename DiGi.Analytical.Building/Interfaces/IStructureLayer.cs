namespace DiGi.Analytical.Building.Interfaces
{
    public interface IStructureLayer : IBuildingGuidObject
    {
        int Index { get; }

        double Thickness { get; }
    }
}