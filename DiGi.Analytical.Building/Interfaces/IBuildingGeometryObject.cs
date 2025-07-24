using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Object.Core.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IBuildingGeometryObject : IBuildingGuidObject, IGeometryObject
    {

    }

    public interface IBuildingGeometryObject<T> : IBuildingGeometry3DObject, IGeometryObject<T> where T: IGeometry
    {
        T Geometry { get; }
    }
}
