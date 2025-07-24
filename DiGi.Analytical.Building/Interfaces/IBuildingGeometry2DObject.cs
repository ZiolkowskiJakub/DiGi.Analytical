using DiGi.Geometry.Object.Planar.Interfaces;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IBuildingGeometry2DObject : IBuildingGeometryObject, IGeometry2DObject
    {

    }

    public interface IBuildingGeometry2DObject<T> : IBuildingGeometryObject<T>, IBuildingGeometry2DObject, IGeometry2DObject<T> where T: IGeometry2D
    {
        T Geometry { get; }
    }
}
