using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IBuildingComponent : IBuildingGeometryObject
    {

    }

    public interface IBuildingComponent<T> : IBuildingComponent, IBuildingGeometryObject<T> where T: IGeometry3D
    {

    }
}
