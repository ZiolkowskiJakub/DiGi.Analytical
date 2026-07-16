using System.Collections.Generic;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building structures composed of multiple structure layers.
    /// </summary>
    public interface IStructure : IBuildingSerializableObject
    {
        /// <summary>
        /// Gets the list of structure layers that make up this structure.
        /// </summary>
        List<IStructureLayer> StructureLayers { get; }
    }
}