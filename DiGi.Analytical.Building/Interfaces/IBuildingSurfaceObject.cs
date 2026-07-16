using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building objects that have a 3D surface geometry.
    /// </summary>
    public interface IBuildingSurfaceObject : IBuildingGeometryObject<ISurface3D>
    {
    }
}