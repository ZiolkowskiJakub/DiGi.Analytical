using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class ComponentConstructionStructureLayersRelation : ConstructionStructureLayersRelation<IPhysicalComponentConstruction>
    {
        public ComponentConstructionStructureLayersRelation(IPhysicalComponentConstruction? physicalComponentConstruction, IStructureLayer? structureLayer)
            : base(physicalComponentConstruction, structureLayer)
        {

        }

        public ComponentConstructionStructureLayersRelation(IPhysicalComponentConstruction? physicalComponentConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(physicalComponentConstruction, structureLayers)
        {

        }

        public ComponentConstructionStructureLayersRelation(ComponentConstructionStructureLayersRelation? componentConstructionStructureLayersRelation)
            : base(componentConstructionStructureLayersRelation)
        {

        }

        public ComponentConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }
    }
}
