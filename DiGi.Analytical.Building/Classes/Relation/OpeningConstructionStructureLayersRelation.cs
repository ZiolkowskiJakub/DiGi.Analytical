using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class OpeningConstructionStructureLayersRelation : ConstructionStructureLayersRelation<IOpeningConstruction>
    {
        public OpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IStructureLayer? structureLayer)
            : base(openingConstruction, Core.Query.CloneAndFilterNulls([structureLayer]))
        {
        }

        public OpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(openingConstruction, structureLayers)
        {
        }

        public OpeningConstructionStructureLayersRelation(OpeningConstructionStructureLayersRelation? openingConstructionStructureLayersRelation)
            : base(openingConstructionStructureLayersRelation)
        {
        }

        public OpeningConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}