using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Urban.Classes
{
    /// <summary>
    /// Represents urban-related information for a building object, providing spatial context through coordinates.
    /// </summary>
    public class UrbanInformation : SerializableObject, IBuildingObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanInformation"/> class using an existing <see cref="UrbanInformation"/> instance.
        /// </summary>
        /// <param name="urbanInformation">The source <see cref="UrbanInformation"/> object to copy data from. This value can be null.</param>
        public UrbanInformation(UrbanInformation? urbanInformation)
            : base(urbanInformation)
        {
            if (urbanInformation != null)
            {
                Coordinates = Core.Query.Clone(urbanInformation.Coordinates);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanInformation"/> class.
        /// </summary>
        public UrbanInformation()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrbanInformation"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public UrbanInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the geographic coordinates associated with the urban information.
        /// </summary>
        [JsonInclude, JsonPropertyName("Coordinates")]
        public Coordinates? Coordinates { get; set; } = new Coordinates(0, 0);
    }
}