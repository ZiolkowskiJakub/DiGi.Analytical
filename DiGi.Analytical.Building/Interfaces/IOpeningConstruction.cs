namespace DiGi.Analytical.Building.Interfaces
{
    public interface IOpeningConstruction : IConstruction
    {
        IStructure PaneStructure { get; }
        IStructure FrameStructure { get; }
    }
}
