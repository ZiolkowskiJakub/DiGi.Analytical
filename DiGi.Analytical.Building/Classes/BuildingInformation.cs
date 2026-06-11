using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents detailed information regarding a building, providing properties for its address, geographical coordinates, and UTC offset.
    /// </summary>
    public class BuildingInformation : SerializableObject, IBuildingObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingInformation"/> class by copying the values from an existing <see cref="BuildingInformation"/> instance.
        /// </summary>
        /// <param name="buildingInformation">The source <see cref="BuildingInformation"/> object to copy data from; can be null.</param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingInformation"/> class.
        /// </summary>
        public BuildingInformation()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingInformation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the building information data.</param>
        public BuildingInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the physical mailing address of the building.
        /// </summary>
        [JsonInclude, JsonPropertyName("Address")]
        public Address? Address { get; set; }

        /// <summary>
        /// Gets or sets the geographic coordinates of the building.
        /// </summary>
        [JsonInclude, JsonPropertyName("Coordinates")]
        public Coordinates? Coordinates { get; set; } = new Coordinates(0, 0);

        /// <summary>
        /// Gets or sets the Coordinated Universal Time (UTC) time zone associated with the building information.
        /// </summary>
        [JsonInclude, JsonPropertyName("UTC")]
        public Core.Enums.UTC UTC { get; set; }
    }
}