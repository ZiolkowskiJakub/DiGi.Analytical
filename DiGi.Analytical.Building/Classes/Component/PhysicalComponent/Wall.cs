using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an abstract base class for a wall component within a building's analytical structure.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry associated with the wall, which must implement <see cref="IGeometry3D"/>.</typeparam>
    public abstract class Wall<T> : PhysicalComponent<T>, IWall<T> where T : IGeometry3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wall{T}"/> class with the specified geometry.
        /// </summary>
        /// <param name="geometry">The optional 3D geometry to associate with the wall.</param>
        public Wall(T? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wall{T}"/> class using an existing wall instance.
        /// </summary>
        /// <param name="wall">The source <see cref="Wall{T}"/> instance to copy from.</param>
        public Wall(Wall<T>? wall)
            : base(wall)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wall{T}"/> class using a specified unique identifier and an optional source wall object.
        /// </summary>
        /// <param name="guid">The unique identifier for the wall.</param>
        /// <param name="wall">An existing wall instance from which to copy properties, such as the structure position.</param>
        public Wall(System.Guid guid, Wall<T>? wall)
            : base(guid, wall)
        {
            if (wall is not null)
            {
                StructurePosition = wall.StructurePosition;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wall{T}"/> class using an existing wall and specific geometry.
        /// </summary>
        /// <param name="wall">The source wall from which to copy properties.</param>
        /// <param name="geometry">The 3D geometry to assign to the wall.</param>
        public Wall(IWall? wall, T? geometry)
            : base(wall as PhysicalComponent, geometry)
        {
            if (wall is not null)
            {
                StructurePosition = wall.StructurePosition;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wall{T}"/> class using the specified unique identifier and geometry.
        /// </summary>
        /// <param name="guid">The unique identifier for the wall.</param>
        /// <param name="geometry">The 3D geometry to assign to the wall.</param>
        public Wall(System.Guid guid, T? geometry)
            : base(guid, geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wall{T}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data for initialization.</param>
        public Wall(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}