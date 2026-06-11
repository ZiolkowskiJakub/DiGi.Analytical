using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Classes;
using DiGi.Analytical.Urban.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Urban.Classes
{
    /// <summary>
    /// Represents a one-to-one bidirectional relationship between a <see cref="BuildingModel"/> and a <see cref="BoundingBox"/>.
    /// </summary>
    public class BuildingModelBoundingBoxRelation : OneToOneBidirectionalRelation<BuildingModel, BoundingBox>, IUrbanRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelBoundingBoxRelation"/> class.
        /// </summary>
        /// <param name="buildingModel">The building model associated with this relation.</param>
        /// <param name="boundingBox3D">The 3D bounding box associated with this relation.</param>
        public BuildingModelBoundingBoxRelation(BuildingModel? buildingModel, BoundingBox? boundingBox3D)
            : base(buildingModel, boundingBox3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelBoundingBoxRelation"/> class using an existing relation instance.
        /// </summary>
        /// <param name="buildingModelBoundingBoxRelation">The existing <see cref="BuildingModelBoundingBoxRelation"/> instance to copy from.</param>
        public BuildingModelBoundingBoxRelation(BuildingModelBoundingBoxRelation? buildingModelBoundingBoxRelation)
            : base(buildingModelBoundingBoxRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModelBoundingBoxRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the relation.</param>
        public BuildingModelBoundingBoxRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}