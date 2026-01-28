using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingInformation : SerializableObject, IBuildingObject
    {
        public BuildingInformation(BuildingInformation? buildingInformation)
            : base(buildingInformation)
        {
            if (buildingInformation != null)
            {
                Address = Core.Query.Clone(buildingInformation.Address);
                Coordinates = Core.Query.Clone(buildingInformation.Coordinates);
                UTC = buildingInformation.UTC;
            }
        }

        public BuildingInformation()
            : base()
        {
        }

        public BuildingInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonInclude, JsonPropertyName("Address")]
        public Address? Address { get; set; }

        [JsonInclude, JsonPropertyName("Coordinates")]
        public Coordinates? Coordinates { get; set; } = new Coordinates(0, 0);

        [JsonInclude, JsonPropertyName("UTC")]
        public Core.Enums.UTC UTC { get; set; }
    }
}