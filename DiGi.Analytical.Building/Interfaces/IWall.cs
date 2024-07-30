using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IWall : IComponent, IBuildingGeometryObject
    {

    }

    public interface IWall<T> : IWall, IBuildingGeometryObject<T> where T : IGeometry3D
    {

    }
}
