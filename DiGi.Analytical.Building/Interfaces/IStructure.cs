using System.Collections.Generic;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IStructure : IBuildingObject
    {
        List<IStructureLayer> StructureLayers { get; }
    }
}
