using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingRelationCluster : UniqueObjectRelationCluster<IBuildingUniqueObject>, IBuildingObject
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
    }
}
