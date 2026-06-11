using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Classes;
using DiGi.Analytical.Urban.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Urban.Classes
{
    /// <summary>
    /// Represents an urban model that manages urban-related information and relation clusters within a parametrized GUID object framework.
    /// </summary>
    public class UrbanModel : ParametrizedGuidObject, IUrbanGuidObject, IGuidModel
    {
        [JsonInclude, JsonPropertyName("UrbanRelationCluster"), System.ComponentModel.Description("UrbanRelationCluster")]
        private readonly UrbanRelationCluster urbanRelationCluster = [];

        [JsonInclude, JsonPropertyName("UrbanInformation"), System.ComponentModel.Description("UrbanInformation")]
        private UrbanInformation urbanInformation = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanModel"/> class by cloning an existing urban model.
        /// </summary>
        /// <param name="urbanModel">The source <see cref="UrbanModel"/> to clone from; if null, a default instance is initialized.</param>
        public UrbanModel(UrbanModel? urbanModel)
            : base(urbanModel)
        {
            if (urbanModel != null)
            {
                urbanRelationCluster = Core.Query.Clone(urbanModel.urbanRelationCluster) ?? [];
                urbanInformation = Core.Query.Clone(urbanModel.urbanInformation) ?? new();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanModel"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the model; may be null.</param>
        public UrbanModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the urban information associated with this urban model.
        /// </summary>
        [JsonIgnore]
        public UrbanInformation UrbanInformation
        {
            get
            {
                return urbanInformation;
            }

            set
            {
                if (value is null)
                {
                    return;
                }

                urbanInformation = value;
            }
        }

        /// <summary>
        /// Gets the axis-aligned bounding box encompassing all building models within the urban model.
        /// </summary>
        /// <returns>The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> representing the combined bounding box of all buildings, or null if no valid bounding boxes could be determined.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            if (urbanRelationCluster.GetValues<BuildingModel>() is not List<BuildingModel> buildingModels || buildingModels.Count == 0)
            {
                return null;
            }

            List<BoundingBox3D> boundingBox3Ds = [];
            foreach (BuildingModel buildingModel in buildingModels)
            {
                if (GetBoundingBox(buildingModel) is BoundingBox3D boundingBox3D)
                {
                    boundingBox3Ds.Add(boundingBox3D);
                }
            }

            if (boundingBox3Ds is null || boundingBox3Ds.Count == 0)
            {
                return null;
            }

            return Geometry.Spatial.Create.BoundingBox3D(boundingBox3Ds);
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the specified building model.
        /// </summary>
        /// <param name="buildingModel">The building model for which to retrieve the bounding box.</param>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box of the building model, or null if it cannot be determined or the provided model is null.</returns>
        public BoundingBox3D? GetBoundingBox(BuildingModel? buildingModel)
        {
            if (buildingModel is null)
            {
                return null;
            }

            BoundingBox? boundingBox;

            BuildingModelBoundingBoxRelation? buildingModelBoundingBoxRelation = urbanRelationCluster.GetRelation<BuildingModelBoundingBoxRelation>(buildingModel);
            if (buildingModelBoundingBoxRelation is not null)
            {
                boundingBox = urbanRelationCluster.GetValue<BoundingBox>(buildingModelBoundingBoxRelation, Core.Relation.Enums.RelationSide.To);
                if (boundingBox is null)
                {
                    urbanRelationCluster.Remove(buildingModelBoundingBoxRelation);
                }

                return new BoundingBox3D(boundingBox);
            }

            BoundingBox3D? result = buildingModel.GetBoundingBox();

            boundingBox = new(buildingModel.UniqueReference(), result);
            if (urbanRelationCluster.Add(boundingBox))
            {
                buildingModelBoundingBoxRelation = new BuildingModelBoundingBoxRelation(buildingModel, boundingBox);
                urbanRelationCluster.AddRelation(buildingModelBoundingBoxRelation);
            }

            return result;
        }

        /// <summary>
        /// Removes the specified building model from the urban model.
        /// </summary>
        /// <param name="buildingModel">The building model to be removed.</param>
        /// <returns>True if the building model was successfully removed; otherwise, false.</returns>
        public bool Remove(BuildingModel? buildingModel)
        {
            return Remove(buildingModel == null ? null : new GuidReference(buildingModel));
        }

        /// <summary>
        /// Removes the specified GUID reference from the urban model.
        /// </summary>
        /// <param name="guidReference">The GUID reference of the object to be removed.</param>
        /// <returns>True if the reference was successfully removed; otherwise, false.</returns>
        public bool Remove(GuidReference? guidReference)
        {
            if (guidReference is null)
            {
                return false;
            }

            return urbanRelationCluster.Remove(guidReference);
        }

        /// <summary>
        /// Updates the specified building model within the urban model, refreshing its associated bounding box relations.
        /// </summary>
        /// <param name="buildingModel">The building model instance to be updated.</param>
        /// <returns>True if the update operation was successful; otherwise, false.</returns>
        public bool Update(BuildingModel? buildingModel)
        {
            if (buildingModel == null)
            {
                return false;
            }

            BuildingModelBoundingBoxRelation? buildingModelBoundingBoxRelation = urbanRelationCluster.GetRelation<BuildingModelBoundingBoxRelation>(buildingModel);
            if (buildingModelBoundingBoxRelation is not null)
            {
                BoundingBox? boundingBox = urbanRelationCluster.GetValue<BoundingBox>(buildingModelBoundingBoxRelation, Core.Relation.Enums.RelationSide.To);
                if (boundingBox is not null)
                {
                    urbanRelationCluster.Remove(boundingBox);
                }
                urbanRelationCluster.Remove(buildingModelBoundingBoxRelation);
            }

            return urbanRelationCluster.Add(buildingModel.Clone<BuildingModel>());
        }
    }
}