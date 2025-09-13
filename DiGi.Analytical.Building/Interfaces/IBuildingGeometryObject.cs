using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Object.Core.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IBuildingGeometryObject : IBuildingGuidObject, IGeometryObject
    {

    }

    public interface IBuildingGeometryObject<TGeometry> : IBuildingGeometry3DObject, IGeometryObject<TGeometry> where TGeometry: IGeometry
    {

    }
}
