using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract physical component that defines the characteristics of a roof within a building model.
    /// </summary>
    /// <typeparam name="T">The type of 3D surface geometry used to represent the roof, which must implement <see cref="ISurface3D"/>.</typeparam>
    public abstract class Roof<T> : PhysicalComponent<T>, IRoof where T : ISurface3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Roof{T}"/> class with the specified geometry.
        /// </summary>
        /// <param name="geometry">The geometry to associate with the roof.</param>
        public Roof(T? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Roof{T}"/> class by copying the specified roof.
        /// </summary>
        /// <param name="roof">The source <see cref="Roof{T}"/> instance to copy from.</param>
        public Roof(Roof<T>? roof)
            : base(roof)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Roof{T}"/> class using a specified unique identifier and an existing roof object.
        /// </summary>
        /// <param name="guid">The unique identifier for the roof.</param>
        /// <param name="roof">The existing roof instance to copy properties from.</param>
        public Roof(System.Guid guid, Roof<T>? roof)
            : base(guid, roof)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Roof{T}"/> class using the specified roof and geometry.
        /// </summary>
        /// <param name="roof">The existing <see cref="IRoof"/> instance to initialize from.</param>
        /// <param name="geometry">The geometry to associate with the roof.</param>
        public Roof(IRoof? roof, T? geometry)
            : base(roof as PhysicalComponent, geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Roof{T}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the roof instance.</param>
        public Roof(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}
