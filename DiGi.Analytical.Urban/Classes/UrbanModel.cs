using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Urban.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
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

        public bool Update(BuildingModel? buildingModel)
        {
            if (buildingModel == null)
            {
                return false;
            }

            return urbanRelationCluster.Add(buildingModel.Clone<BuildingModel>());
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
    }
}
