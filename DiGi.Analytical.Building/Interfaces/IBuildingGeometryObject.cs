using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IBuildingGeometryObject : IBuildingUniqueObject, IGeometry3DObject
    {

    }

    public interface IBuildingGeometryObject<T> : IBuildingGeometryObject, IGeometry3DObject<T> where T: IGeometry3D
    {
        T Geometry { get; }
    }
}
