using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IAbstractComponent : IComponent, IBuildingBoundable3D
    {
    }

    public interface IAbstractComponent<TGeometry3D> : IAbstractComponent, IBuildingGeometryObject<TGeometry3D> where TGeometry3D : IGeometry3D
    {
    }
}