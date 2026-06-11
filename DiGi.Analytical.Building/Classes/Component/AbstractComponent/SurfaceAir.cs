using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an analytical building air element associated with a 3D surface.
    /// </summary>
    public class SurfaceAir : Air<ISurface3D>, ISurfaceAir
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceAir"/> class using an existing <see cref="SurfaceAir"/> instance.
        /// </summary>
        /// <param name="surfaceAir">The source <see cref="SurfaceAir"/> instance to copy from.</param>
        public SurfaceAir(SurfaceAir? surfaceAir)
            : base(surfaceAir)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceAir"/> class using the specified surface geometry.
        /// </summary>
        /// <param name="geometry">The surface geometry to associate with this air surface. This value can be null.</param>
        public SurfaceAir(ISurface3D? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceAir"/> class using a unique identifier and an existing <see cref="SurfaceAir"/> object.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="surfaceAir">An optional <see cref="SurfaceAir"/> instance to initialize from.</param>
        public SurfaceAir(System.Guid guid, SurfaceAir? surfaceAir)
            : base(guid, surfaceAir)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceAir"/> class using the specified air object and geometry surface.
        /// </summary>
        /// <param name="air">The <see cref="IAir"/> object to provide base properties.</param>
        /// <param name="geometry">The <see cref="ISurface3D"/> geometry associated with this surface air element.</param>
        public SurfaceAir(IAir? air, ISurface3D? geometry)
            : base(air, geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceAir"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the instance.</param>
        public SurfaceAir(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the surface air's geometry.
        /// </summary>
        /// <returns>The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> encompassing the geometry, or null if no geometry is defined.</returns>
        public override BoundingBox3D? GetBoundingBox()
        {
            return Geometry?.GetBoundingBox();
        }
    }
}