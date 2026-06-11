using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a wall in an analytical building model where the geometry is defined as a 3D surface.
    /// </summary>
    public class SurfaceWall : Wall<ISurface3D>, ISurfaceWall
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceWall"/> class using an existing <see cref="SurfaceWall"/> instance.
        /// </summary>
        /// <param name="surfaceWall">The source <see cref="SurfaceWall"/> instance to copy from.</param>
        public SurfaceWall(SurfaceWall? surfaceWall)
            : base(surfaceWall)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceWall"/> class using the specified geometry.
        /// </summary>
        /// <param name="geometry">The <see cref="ISurface3D"/> geometry to assign to the wall. This value can be null.</param>
        public SurfaceWall(ISurface3D? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceWall"/> class with a specified unique identifier and an optional existing surface wall.
        /// </summary>
        /// <param name="guid">The unique identifier for the surface wall.</param>
        /// <param name="surfaceWall">An optional existing <see cref="SurfaceWall"/> instance to initialize from.</param>
        public SurfaceWall(System.Guid guid, SurfaceWall? surfaceWall)
            : base(guid, surfaceWall)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceWall"/> class using an existing wall and a specific surface geometry.
        /// </summary>
        /// <param name="wall">The source wall from which to copy properties.</param>
        /// <param name="geometry">The surface geometry associated with the wall.</param>
        public SurfaceWall(IWall? wall, ISurface3D? geometry)
            : base(wall, geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceWall"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="System.Text.Json.Nodes.JsonObject"/> containing the data used to initialize this instance.</param>
        public SurfaceWall(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the surface wall.
        /// </summary>
        /// <returns>The bounding box encompassing the surface wall, or null if it cannot be determined.</returns>
        public override BoundingBox3D? GetBoundingBox()
        {
            return Geometry?.GetBoundingBox();
        }
    }
}