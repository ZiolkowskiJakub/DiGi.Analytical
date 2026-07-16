using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for air regions defined by a 3D surface geometry.
    /// </summary>
    public interface ISurfaceAir : IAir<ISurface3D>, IBuildingSurfaceObject
    {
    }
}