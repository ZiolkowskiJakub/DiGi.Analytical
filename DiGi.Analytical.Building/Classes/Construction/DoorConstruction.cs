using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a door construction element within the analytical building model, providing functionality for managing door-specific openings.
    /// </summary>
    public class DoorConstruction : OpeningConstruction<IDoor>, IDoorConstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoorConstruction"/> class.
        /// </summary>
        /// <param name="name">The optional name of the door construction.</param>
        /// <param name="surface2D">The optional 2D surface associated with the door construction.</param>
        public DoorConstruction(string? name, ISurface2D? surface2D)
            : base(name, surface2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoorConstruction"/> class using an existing <see cref="DoorConstruction"/> instance.
        /// </summary>
        /// <param name="doorConstruction">The source <see cref="DoorConstruction"/> instance to copy from.</param>
        public DoorConstruction(DoorConstruction? doorConstruction)
            : base(doorConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoorConstruction"/> class with a specified unique identifier and an existing door construction.
        /// </summary>
        /// <param name="guid">The unique identifier for the door construction.</param>
        /// <param name="doorConstruction">An optional existing <see cref="DoorConstruction"/> instance to copy properties from.</param>
        public DoorConstruction(System.Guid guid, DoorConstruction? doorConstruction)
            : base(guid, doorConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoorConstruction"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public DoorConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}