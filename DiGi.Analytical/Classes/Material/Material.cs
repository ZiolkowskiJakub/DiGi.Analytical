using DiGi.Analytical.Interfaces;
using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a base abstraction for materials within the analytical system, providing common functionality and properties shared by all material types.
    /// </summary>
    public abstract class Material : GuidObject, IMaterial
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string? description;

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Material"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the material.</param>
        public Material(string? name)
            : base()
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Material"/> class using another <see cref="Material"/> instance.
        /// </summary>
        /// <param name="material">The source material instance from which to copy values. This value can be null.</param>
        public Material(Material? material)
            : base(material)
        {
            if (material != null)
            {
                name = material.name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Material"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to populate the properties of the material instance.</param>
        public Material(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the description of the material.
        /// </summary>
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
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
        /// Gets or sets the name of the material.
        /// </summary>
        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
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