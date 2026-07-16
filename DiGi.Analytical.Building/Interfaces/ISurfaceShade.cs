using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for shading elements defined by a 3D surface geometry.
    /// </summary>
    public interface ISurfaceShade : IShade<ISurface3D>, IBuildingSurfaceObject
    {
    }
}