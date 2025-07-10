using DiGi.Analytical.Building.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class Zone : BuildingObject, IZone
    {
        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string name;

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Zone(string name)
            :base()
        {
            this.name = name;
        }

        public Zone(JsonObject jsonObject)
            : base(jsonObject)
        {
           
        }

        public Zone(Zone zone)
            : base(zone)
        {
            if(zone != null)
            {
                name = zone.name;
            }
        }

        public Zone(System.Guid guid, Zone zone)
            : base(guid, zone)
        {
            if (zone != null)
            {
                name = zone.name;
            }
        }
    }
}
