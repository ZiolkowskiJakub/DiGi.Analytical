using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for a floor component within a building's analytical model.
    /// </summary>
    /// <typeparam name="T">The type of 3D geometry associated with the floor, which must implement <see cref="IGeometry3D"/>.</typeparam>
    public abstract class Floor<T> : PhysicalComponent<T>, IFloor where T : IGeometry3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Floor{T}"/> class with the specified geometry.
        /// </summary>
        /// <param name="geometry">The geometry to associate with the floor instance.</param>
        public Floor(T? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Floor{T}"/> class using an existing <see cref="Floor{T}"/> instance.
        /// </summary>
        /// <param name="floor">The source <see cref="Floor{T}"/> instance to copy from.</param>
        public Floor(Floor<T>? floor)
            : base(floor)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Floor{T}"/> class with a specified unique identifier and an optional source floor.
        /// </summary>
        /// <param name="guid">The unique identifier for the floor.</param>
        /// <param name="floor">An existing <see cref="Floor{T}"/> instance to initialize from.</param>
        public Floor(System.Guid guid, Floor<T>? floor)
            : base(guid, floor)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Floor{T}"/> class using an existing floor implementation and specified geometry.
        /// </summary>
        /// <param name="floor">The source floor object used to initialize the current instance.</param>
        /// <param name="geometry">The 3D geometry associated with this floor.</param>
        public Floor(IFloor? floor, T? geometry)
            : base(floor as PhysicalComponent, geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Floor{T}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data used to initialize the instance.</param>
        public Floor(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}