using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class ConstructionStructureLayersRelation<TConstruction> : OneToManyBidirectionalRelation<TConstruction, IStructureLayer>, IBuildingRelation where TConstruction : IConstruction
    {
        public ConstructionStructureLayersRelation(TConstruction? construction, IStructureLayer? structureLayer)
            : base(construction, Core.Query.CloneAndFilterNulls([structureLayer]))
        {
        }

        public ConstructionStructureLayersRelation(TConstruction? construction, IEnumerable<IStructureLayer>? structureLayers)
            : base(construction, structureLayers)
        {
        }

        public ConstructionStructureLayersRelation(ConstructionStructureLayersRelation<TConstruction>? constructionStructureLayersRelation)
            : base(constructionStructureLayersRelation)
        {
        }

        public ConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}