using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
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
    public class UrbanModel : ParametrizedGuidObject, IUrbanGuidObject, IGuidModel
    {
        [JsonInclude, JsonPropertyName("UrbanRelationCluster"), System.ComponentModel.Description("UrbanRelationCluster")]
        private readonly UrbanRelationCluster urbanRelationCluster = [];

        [JsonInclude, JsonPropertyName("UrbanInformation"), System.ComponentModel.Description("UrbanInformation")]
        private UrbanInformation urbanInformation = new();

        public UrbanModel(UrbanModel? urbanModel)
            :base(urbanModel)
        {
            if (urbanModel != null)
            {
                urbanRelationCluster = Core.Query.Clone(urbanModel.urbanRelationCluster) ?? [];
                urbanInformation = Core.Query.Clone(urbanModel.urbanInformation) ?? new();
            }
        }

        public UrbanModel(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

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

            boundingBox = new (buildingModel.UniqueReference(), result);
            if(urbanRelationCluster.Add(boundingBox))
            {
                buildingModelBoundingBoxRelation = new BuildingModelBoundingBoxRelation(buildingModel, boundingBox);
                urbanRelationCluster.AddRelation(buildingModelBoundingBoxRelation);
            }

            return result;
        }

        public bool Remove(BuildingModel? buildingModel)
        {
            return Remove(buildingModel == null ? null : new GuidReference(buildingModel));
        }

        public bool Remove(GuidReference? guidReference)
        {
            if (guidReference is null)
            {
                return false;
            }

            return urbanRelationCluster.Remove(guidReference);
        }

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
