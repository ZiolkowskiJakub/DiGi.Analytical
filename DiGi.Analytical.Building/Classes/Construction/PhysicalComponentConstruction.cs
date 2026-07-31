using DiGi.Analytical.Building.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the abstract base class for the construction specifications of a physical building component.
    /// </summary>
    public abstract class PhysicalComponentConstruction : BuildingNamedObject, IPhysicalComponentConstruction
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string? description;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstruction"/> class.
        /// </summary>
        public PhysicalComponentConstruction()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstruction"/> class using the specified construction object.
        /// </summary>
        /// <param name="componentConstruction">The source <see cref="PhysicalComponentConstruction"/> object to copy properties from.</param>
        public PhysicalComponentConstruction(PhysicalComponentConstruction? componentConstruction)
            : base(componentConstruction)
        {
            if (componentConstruction is not null)
            {
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstruction"/> class using a specified unique identifier and an optional source construction object.
        /// </summary>
        /// <param name="guid">The unique global identifier for the physical component construction.</param>
        /// <param name="componentConstruction">An optional existing <see cref="PhysicalComponentConstruction"/> instance to copy properties from.</param>
        public PhysicalComponentConstruction(System.Guid guid, PhysicalComponentConstruction? componentConstruction)
            : base(guid, componentConstruction)
        {
            if (componentConstruction is not null)
            {
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstruction"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the instance; may be null.</param>
        public PhysicalComponentConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the description of the physical component construction.
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
    }
}