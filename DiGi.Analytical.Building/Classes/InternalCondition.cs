using DiGi.Analytical.Building.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the internal condition of a building object, containing descriptive information about its current state.
    /// </summary>
    public class InternalCondition : BuildingObject, IInternalCondition
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string? description;

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalCondition"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the internal condition.</param>
        public InternalCondition(string? name)
            : base()
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalCondition"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public InternalCondition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalCondition"/> class using an existing <see cref="InternalCondition"/> instance.
        /// </summary>
        /// <param name="internalCondition">The source <see cref="InternalCondition"/> instance to copy values from.</param>
        public InternalCondition(InternalCondition? internalCondition)
            : base(internalCondition)
        {
            if (internalCondition != null)
            {
                name = internalCondition.name;
                description = internalCondition.description;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalCondition"/> class using a specified unique identifier and an optional existing condition to copy values from.
        /// </summary>
        /// <param name="guid">The unique global identifier for the internal condition.</param>
        /// <param name="internalCondition">An optional <see cref="InternalCondition"/> instance used to initialize the properties of the new instance.</param>
        public InternalCondition(System.Guid guid, InternalCondition? internalCondition)
            : base(guid, internalCondition)
        {
            if (internalCondition != null)
            {
                name = internalCondition.name;
                description = internalCondition.description;
            }
        }

        /// <summary>
        /// Gets or sets the description of the internal condition.
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
        /// Gets or sets the name of the internal condition.
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