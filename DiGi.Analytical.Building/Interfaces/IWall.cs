using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IWall : IBuildingGeometryObject
    {

    }

    public interface ISurfaceWall : IWall, IBuildingGeometryObject<ISurface3D>
    {

    }

    public interface ICurveWall : IWall, IBuildingGeometryObject<ICurve3D>
    {

    }
}
