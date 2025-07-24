using System.Collections.Generic;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IStructure : IBuildingSerializableObject
    {
        List<IStructureLayer> StructureLayers { get; }
    }
}
