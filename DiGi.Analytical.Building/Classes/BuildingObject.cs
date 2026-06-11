using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for building objects that possess a name identifier.
    /// </summary>
    public abstract class BuildingNamedObject : BuildingObject, IBuildingNamedObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingNamedObject"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name to assign to the building named object. This value can be null.</param>
        public BuildingNamedObject(string? name)
            : base()
        {
            Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingNamedObject"/> class using an existing <see cref="BuildingNamedObject"/> object.
        /// </summary>
        /// <param name="buildingNamedObject">The source <see cref="BuildingNamedObject"/> object to copy values from. This value can be null.</param>
        public BuildingNamedObject(BuildingNamedObject? buildingNamedObject)
            : base(buildingNamedObject)
        {
            if (buildingNamedObject != null)
            {
                Name = buildingNamedObject.Name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingNamedObject"/> class using a specified unique identifier and an optional existing object to copy values from.
        /// </summary>
        /// <param name="guid">The unique identifier for the building named object.</param>
        /// <param name="buildingNamedObject">An optional <see cref="BuildingNamedObject"/> instance used to initialize the properties of the new instance.</param>
        public BuildingNamedObject(System.Guid guid, BuildingNamedObject? buildingNamedObject)
            : base(guid, buildingNamedObject)
        {
            if (buildingNamedObject != null)
            {
                Name = buildingNamedObject.Name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingNamedObject"/> class.
        /// </summary>
        public BuildingNamedObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingNamedObject"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the instance. This value can be null.</param>
        public BuildingNamedObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingNamedObject"/> class with the specified unique identifier and name.
        /// </summary>
        /// <param name="guid">The unique identifier for the building named object.</param>
        /// <param name="name">The name of the building named object.</param>
        public BuildingNamedObject(System.Guid guid, string? name)
            : base(guid)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets the name of the building named object.
        /// </summary>
        [JsonInclude, JsonPropertyName("Name")]
        public string? Name { get; set; }
    }
}