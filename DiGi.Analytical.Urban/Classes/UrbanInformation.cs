using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Urban.Classes
{
    public class UrbanInformation : SerializableObject, IBuildingObject
    {
        public UrbanInformation(UrbanInformation? urbanInformation)
            : base(urbanInformation)
        {
            if (urbanInformation != null)
            {
                Coordinates = Core.Query.Clone(urbanInformation.Coordinates);
            }
        }

        public UrbanInformation()
            : base()
        {

        }

        public UrbanInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Coordinates")]
        public Coordinates? Coordinates { get; set; } = new Coordinates(0, 0);
    }
}
