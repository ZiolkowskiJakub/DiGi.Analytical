using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IBuildingGeometry3DObject : IBuildingGeometryObject, IGeometry3DObject
    {

    }

    public interface IBuildingGeometry3DObject<T> : IBuildingGeometryObject<T>, IBuildingGeometry3DObject, IGeometry3DObject<T> where T: IGeometry3D
    {
        T Geometry { get; }
    }
}
