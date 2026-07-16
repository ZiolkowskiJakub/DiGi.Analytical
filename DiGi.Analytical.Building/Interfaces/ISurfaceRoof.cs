using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for roofs defined by a 3D surface geometry.
    /// </summary>
    public interface ISurfaceRoof : IRoof, IBuildingSurfaceObject, IComponent<ISurface3D>
    {
    }
}