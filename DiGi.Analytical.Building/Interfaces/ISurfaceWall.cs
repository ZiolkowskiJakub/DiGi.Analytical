using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for walls defined by a 3D surface geometry.
    /// </summary>
    public interface ISurfaceWall : IWall, IBuildingSurfaceObject, IComponent<ISurface3D>
    {
    }
}