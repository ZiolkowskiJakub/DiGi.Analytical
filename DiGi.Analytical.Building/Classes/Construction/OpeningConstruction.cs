using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for opening constructions in a building, providing functionality for managing the geometric properties of an opening associated with a 2D surface.
    /// </summary>
    public abstract class OpeningConstruction : BuildingGeometry2DObject<ISurface2D>, IOpeningConstruction
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string? description;

        [JsonInclude, JsonPropertyName("Name")]
        private string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstruction"/> class.
        /// </summary>
        /// <param name="name">The name of the opening construction.</param>
        /// <param name="surface2D">The 2D surface associated with the opening construction.</param>
        public OpeningConstruction(string? name, ISurface2D? surface2D)
            : base(surface2D)
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstruction"/> class by copying an existing instance.
        /// </summary>
        /// <param name="openingConstruction">The source <see cref="OpeningConstruction"/> object to copy from.</param>
        public OpeningConstruction(OpeningConstruction? openingConstruction)
            : base(openingConstruction)
        {
            if (openingConstruction != null)
            {
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstruction"/> class with a specified unique identifier and an optional existing construction object.
        /// </summary>
        /// <param name="guid">The unique global identifier for the opening construction.</param>
        /// <param name="openingConstruction">An optional existing <see cref="OpeningConstruction"/> instance to initialize from.</param>
        public OpeningConstruction(System.Guid guid, OpeningConstruction? openingConstruction)
            : base(guid, openingConstruction)
        {
            if (openingConstruction != null)
            {
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstruction"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the object. This value can be null.</param>
        public OpeningConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the description of the opening construction.
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
        /// Gets or sets the name of the opening construction.
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

    /// <summary>
    /// Represents an abstract base class for a construction of an opening, providing generic support for a specific opening type.
    /// </summary>
    /// <typeparam name="TOpening">The type of the opening associated with this construction, which must implement <see cref="IOpening"/>.</typeparam>
    public abstract class OpeningConstruction<TOpening> : OpeningConstruction, IOpeningConstruction<TOpening> where TOpening : IOpening
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstruction{TOpening}"/> class.
        /// </summary>
        /// <param name="name">The optional name of the opening construction.</param>
        /// <param name="surface2D">The optional 2D surface associated with the opening construction.</param>
        public OpeningConstruction(string? name, ISurface2D? surface2D)
            : base(name, surface2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstruction{TOpening}"/> class using an existing <see cref="OpeningConstruction"/> object.
        /// </summary>
        /// <param name="openingConstruction">The source <see cref="OpeningConstruction"/> object to copy from.</param>
        public OpeningConstruction(OpeningConstruction? openingConstruction)
            : base(openingConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstruction{TOpening}"/> class using the specified unique identifier and an existing opening construction.
        /// </summary>
        /// <param name="guid">The unique global identifier for the object.</param>
        /// <param name="openingConstruction">An optional existing opening construction instance used to initialize the current instance.</param>
        public OpeningConstruction(System.Guid guid, OpeningConstruction? openingConstruction)
            : base(guid, openingConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstruction{TOpening}"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the instance.</param>
        public OpeningConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}