using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a shading element that is associated with a 3D surface.
    /// </summary>
    public class SurfaceShade : Shade<ISurface3D>, ISurfaceShade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceShade"/> class using the specified <see cref="SurfaceShade"/> instance.
        /// </summary>
        /// <param name="surfaceShade">The <see cref="SurfaceShade"/> instance to copy from.</param>
        public SurfaceShade(SurfaceShade? surfaceShade)
            : base(surfaceShade)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceShade"/> class using the specified 3D surface.
        /// </summary>
        /// <param name="surface3D">The 3D surface to be used as the shading element.</param>
        public SurfaceShade(ISurface3D? surface3D)
            : base(surface3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceShade"/> class with a specified unique identifier and an optional source surface shade.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="surfaceShade">An optional existing <see cref="SurfaceShade"/> instance to initialize from.</param>
        public SurfaceShade(System.Guid guid, SurfaceShade? surfaceShade)
            : base(guid, surfaceShade)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceShade"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public SurfaceShade(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}