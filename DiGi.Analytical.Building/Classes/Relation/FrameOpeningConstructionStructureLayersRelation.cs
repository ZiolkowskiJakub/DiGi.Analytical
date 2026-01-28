using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class FrameOpeningConstructionStructureLayersRelation : OpeningConstructionStructureLayersRelation
    {
        public FrameOpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IStructureLayer? structureLayer)
            : base(openingConstruction, Core.Query.CloneAndFilterNulls([structureLayer]))
        {
        }

        public FrameOpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(openingConstruction, structureLayers)
        {
        }

        public FrameOpeningConstructionStructureLayersRelation(FrameOpeningConstructionStructureLayersRelation? frameOpeningConstructionStructureLayersRelation)
            : base(frameOpeningConstructionStructureLayersRelation)
        {
        }

        public FrameOpeningConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}