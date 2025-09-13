using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class ComponentConstructionStructureLayersRelation : ConstructionStructureLayersRelation<IComponentConstruction>
    {
        public ComponentConstructionStructureLayersRelation(IComponentConstruction? componentConstruction, IStructureLayer? structureLayer)
            : base(componentConstruction, structureLayer)
        {

        }

        public ComponentConstructionStructureLayersRelation(IComponentConstruction? componentConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(componentConstruction, structureLayers)
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
