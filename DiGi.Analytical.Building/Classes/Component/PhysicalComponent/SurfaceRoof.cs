using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a building roof defined by a 3D surface geometry.
    /// </summary>
    public class SurfaceRoof : Roof<ISurface3D>, ISurfaceRoof
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceRoof"/> class using an existing <see cref="SurfaceRoof"/> object.
        /// </summary>
        /// <param name="surfaceRoof">The source <see cref="SurfaceRoof"/> instance to copy from.</param>
        public SurfaceRoof(SurfaceRoof? surfaceRoof)
            : base(surfaceRoof)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceRoof"/> class using the specified geometry.
        /// </summary>
        /// <param name="geometry">The <see cref="ISurface3D"/> geometry to associate with the roof. This value can be null.</param>
        public SurfaceRoof(ISurface3D? geometry)
            : base(geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceRoof"/> class using a specified unique identifier and an optional existing roof instance.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="surfaceRoof">An optional <see cref="SurfaceRoof"/> instance to initialize from.</param>
        public SurfaceRoof(System.Guid guid, SurfaceRoof? surfaceRoof)
            : base(guid, surfaceRoof)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceRoof"/> class using an existing roof and surface geometry.
        /// </summary>
        /// <param name="roof">The roof object to initialize from.</param>
        /// <param name="geometry">The surface geometry for the roof.</param>
        public SurfaceRoof(IRoof? roof, ISurface3D? geometry)
            : base(roof, geometry)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceRoof"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data used to initialize the instance. This value can be null.</param>
        public SurfaceRoof(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the surface roof.
        /// </summary>
        /// <returns>The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> encompassing the surface roof, or null if it cannot be determined.</returns>
        public override BoundingBox3D? GetBoundingBox()
        {
            return Geometry?.GetBoundingBox();
        }
    }
}