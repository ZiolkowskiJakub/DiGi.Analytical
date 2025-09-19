using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IPhysicalComponent : IComponent, IBuildingBoundable3D, IConstructable
    {

    }

    public interface IPhysicalComponent<T> : IPhysicalComponent, IBuildingGeometryObject<T> where T: IGeometry3D
    {

    }
}
