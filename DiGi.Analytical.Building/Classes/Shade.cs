using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for shade elements within a building's analytical geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry associated with the shade, which must implement <see cref="IGeometry3D"/>.</typeparam>
    public abstract class Shade<T> : BuildingGeometry3DObject<T>, IShade<T> where T : IGeometry3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shade{T}"/> class using the specified geometry.
        /// </summary>
        /// <param name="geometry">The geometry to be assigned to the shade instance.</param>
        public Shade(T? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shade{T}"/> class using the specified shade object.
        /// </summary>
        /// <param name="shade">The source shade instance from which to initialize this instance.</param>
        public Shade(Shade<T>? shade)
            : base(shade)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shade{T}"/> class with a specified unique identifier and an existing shade object.
        /// </summary>
        /// <param name="guid">The unique global identifier for the shade object.</param>
        /// <param name="shade">The existing shade object to initialize from.</param>
        public Shade(System.Guid guid, Shade<T>? shade)
            : base(guid, shade)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shade{T}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data used to initialize the shade instance.</param>
        public Shade(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}