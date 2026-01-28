using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IComponent : IBuildingBoundable3D, IConstructable
    {
    }

    public interface IComponent<T> : IComponent, IBuildingGeometryObject<T> where T : IGeometry3D
    {
    }
}