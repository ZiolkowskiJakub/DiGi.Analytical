using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a spatial area or room within a building's analytical model, associated with a specific 3D point geometry.
    /// </summary>
    public class Space : BuildingGeometry3DObject<Point3D>, ISpace
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string? description;

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Space"/> class.
        /// </summary>
        /// <param name="geometry">The <see cref="Point3D"/> representing the geometry of the space.</param>
        /// <param name="name">The name of the space.</param>
        public Space(Point3D? geometry, string? name)
            : base(geometry)
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Space"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public Space(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Space"/> class using a specified unique identifier and an optional existing space object to copy properties from.
        /// </summary>
        /// <param name="guid">The unique global identifier for the space.</param>
        /// <param name="space">An optional <see cref="Space"/> instance used to initialize the current instance's properties.</param>
        public Space(System.Guid guid, Space? space)
            : base(guid, space)
        {
            if (space != null)
            {
                name = space.name;
                description = space.description;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Space"/> class by copying properties from an existing <see cref="Space"/> instance.
        /// </summary>
        /// <param name="space">The source <see cref="Space"/> instance to copy data from; may be null.</param>
        public Space(Space? space)
            : base(space)
        {
            if (space != null)
            {
                name = space.name;
                description = space.description;
            }
        }

        /// <summary>
        /// Gets or sets the description of the space.
        /// </summary>
        [JsonIgnore]
        public string? Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the space.
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
    }
}