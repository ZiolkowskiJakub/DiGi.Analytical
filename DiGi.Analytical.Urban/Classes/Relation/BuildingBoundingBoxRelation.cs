using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;
using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Urban.Interfaces;
using DiGi.Analytical.Classes;

namespace DiGi.Analytical.Urban.Classes
{
    public class BuildingModelBoundingBoxRelation : OneToOneBidirectionalRelation<BuildingModel, BoundingBox>, IUrbanRelation
    {
        public BuildingModelBoundingBoxRelation(BuildingModel? buildingModel, BoundingBox? boundingBox3D)
            : base(buildingModel, boundingBox3D)
        {

        }

        public BuildingModelBoundingBoxRelation(BuildingModelBoundingBoxRelation? buildingModelBoundingBoxRelation)
            : base(buildingModelBoundingBoxRelation)
        {

        }

        public BuildingModelBoundingBoxRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }
    }
}
