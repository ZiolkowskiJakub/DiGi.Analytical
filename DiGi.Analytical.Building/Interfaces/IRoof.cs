using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IRoof : IBuildingGeometryObject, IComponent
    {

    }

    public interface ISurfaceRoof : IRoof, IBuildingSurfaceObject, IComponent<ISurface3D>
    {

    }
}
