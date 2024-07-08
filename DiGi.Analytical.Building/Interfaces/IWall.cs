using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IWall : IComponent, IBuildingGeometryObject
    {

    }

    public interface ISurfaceWall : IWall, IBuildingSurfaceObject, IComponent<ISurface3D>
    {

    }

    public interface ICurveWall : IWall, IBuildingCurveObject, IComponent<ICurve3D>
    {

    }
}
