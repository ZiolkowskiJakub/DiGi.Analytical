using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class PaneOpeningConstructionStructureLayersRelation : OpeningConstructionStructureLayersRelation
    {
        public PaneOpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IStructureLayer? structureLayer)
            : base(openingConstruction, Core.Query.CloneAndFilterNulls([structureLayer]))
        {

        }

        public PaneOpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(openingConstruction, structureLayers)
        {

        }

        public PaneOpeningConstructionStructureLayersRelation(PaneOpeningConstructionStructureLayersRelation? paneOpeningConstructionStructureLayersRelation)
            : base(paneOpeningConstructionStructureLayersRelation)
        {

        }

        public PaneOpeningConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }
    }
}