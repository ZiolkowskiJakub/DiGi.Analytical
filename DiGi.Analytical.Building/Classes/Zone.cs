using DiGi.Analytical.Building.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a specific zone within a building, implementing the <see cref="IZone"/> interface and inheriting from <see cref="BuildingObject"/>.
    /// </summary>
    public class Zone : BuildingObject, IZone
    {
        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string? name;

        /// <summary>
        /// Gets or sets the name of the zone.
        /// </summary>
        [JsonIgnore]
        public string? Name
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Zone"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the zone.</param>
        public Zone(string? name)
            : base()
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zone"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the zone.</param>
        public Zone(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zone"/> class using the data from an existing <see cref="Zone"/> instance.
        /// </summary>
        /// <param name="zone">The source <see cref="Zone"/> instance to copy properties from. This value can be null.</param>
        public Zone(Zone? zone)
            : base(zone)
        {
            if (zone != null)
            {
                name = zone.name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zone"/> class using a specified unique identifier and an optional source zone for initialization.
        /// </summary>
        /// <param name="guid">The unique global identifier for the zone.</param>
        /// <param name="zone">An optional <see cref="Zone"/> object from which to copy properties.</param>
        public Zone(System.Guid guid, Zone? zone)
            : base(guid, zone)
        {
            if (zone != null)
            {
                name = zone.name;
            }
        }
    }
}