using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class PhysicalComponentConstructionStructureLayersRelation : ConstructionStructureLayersRelation<IPhysicalComponentConstruction>
    {
        public PhysicalComponentConstructionStructureLayersRelation(IPhysicalComponentConstruction? physicalComponentConstruction, IStructureLayer? structureLayer)
            : base(physicalComponentConstruction, structureLayer)
        {

        }

        public PhysicalComponentConstructionStructureLayersRelation(IPhysicalComponentConstruction? physicalComponentConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(physicalComponentConstruction, structureLayers)
        {

        }

        public PhysicalComponentConstructionStructureLayersRelation(PhysicalComponentConstructionStructureLayersRelation? physicalComponentConstructionStructureLayersRelation)
            : base(physicalComponentConstructionStructureLayersRelation)
        {

        }

        public PhysicalComponentConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }
    }
}
