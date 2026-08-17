using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for terrain elements within a building's analytical geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry associated with the terrain, which must implement <see cref="IGeometry3D"/>.</typeparam>
    public abstract class Terrain<T> : BuildingGeometry3DObject<T>, ITerrain<T> where T : IGeometry3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Terrain{T}"/> class using the specified geometry.
        /// </summary>
        /// <param name="geometry">The geometry to be assigned to the terrain instance.</param>
        public Terrain(T? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Terrain{T}"/> class using the specified terrain object.
        /// </summary>
        /// <param name="terrain">The source terrain instance from which to initialize this instance.</param>
        public Terrain(Terrain<T>? terrain)
            : base(terrain)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Terrain{T}"/> class with a specified unique identifier and an existing terrain object.
        /// </summary>
        /// <param name="guid">The unique global identifier for the terrain object.</param>
        /// <param name="terrain">The existing terrain object to initialize from.</param>
        public Terrain(System.Guid guid, Terrain<T>? terrain)
            : base(guid, terrain)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Terrain{T}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data used to initialize the terrain instance.</param>
        public Terrain(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}
