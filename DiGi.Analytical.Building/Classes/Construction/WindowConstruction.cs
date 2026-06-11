using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the construction details of a window within a building's analytical model, providing functionality for managing window-specific properties and geometry.
    /// </summary>
    public class WindowConstruction : OpeningConstruction<IWindow>, IWindowConstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstruction"/> class.
        /// </summary>
        /// <param name="name">The optional name of the window construction.</param>
        /// <param name="surface2D">The optional 2D surface associated with the window construction.</param>
        public WindowConstruction(string? name, ISurface2D? surface2D)
            : base(name, surface2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstruction"/> class using an existing <see cref="WindowConstruction"/> instance.
        /// </summary>
        /// <param name="windowConstruction">The source <see cref="WindowConstruction"/> instance to copy from.</param>
        public WindowConstruction(WindowConstruction? windowConstruction)
            : base(windowConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstruction"/> class with a specified unique identifier and an optional source window construction.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="windowConstruction">The existing <see cref="WindowConstruction"/> instance to copy properties from.</param>
        public WindowConstruction(System.Guid guid, WindowConstruction? windowConstruction)
            : base(guid, windowConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstruction"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the instance. This value can be null.</param>
        public WindowConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}