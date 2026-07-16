namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for a single layer within a building structure.
    /// </summary>
    public interface IStructureLayer : IBuildingGuidObject
    {
        /// <summary>
        /// Gets the position index of this layer within the parent structure.
        /// </summary>
        int Index { get; }

        /// <summary>
        /// Gets the thickness of the structure layer.
        /// </summary>
        double Thickness { get; }
    }
}