using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingRelationCluster : UniqueObjectRelationCluster<IBuildingUniqueObject, IBuildingRelation>, IBuildingObject
    {
        public BuildingRelationCluster()
            : base()
        {
        }

        public BuildingRelationCluster(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public BuildingRelationCluster(BuildingRelationCluster buildingCluster)
            : base(buildingCluster)
        {
        }

        public BuildingRelationCluster(IEnumerable<IBuildingUniqueObject> buildingUniqueObjects)
            : base(buildingUniqueObjects)
        {
        }

        public ConstructionRelation AddRelation(IWall wall, IWallConstruction wallConstruction)
        {
            return AddRelation(new ConstructionRelation(wall, wallConstruction));
        }

        private ConstructionRelation AddRelation(IComponent component, IConstruction construction)
        {
            if (component == null || construction == null)
            {
                return null;
            }

            ConstructionRelation constructionRelation = GetRelation<ConstructionRelation>(new UniqueReference(component));
            if (constructionRelation != null)
            {
                Remove(constructionRelation);
            }

            return AddRelation(new ConstructionRelation(component, construction));
        }
    }
}
