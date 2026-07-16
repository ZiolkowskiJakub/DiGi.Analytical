using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for abstract building components that are boundable in 3D space.
    /// </summary>
    public interface IAbstractComponent : IComponent, IBuildingBoundable3D
    {
    }

    /// <summary>
    /// Interface for abstract building components with a specific type of 3D geometry.
    /// </summary>
    /// <typeparam name="TGeometry3D">The type of the 3D geometry.</typeparam>
    public interface IAbstractComponent<TGeometry3D> : IAbstractComponent, IBuildingGeometryObject<TGeometry3D> where TGeometry3D : IGeometry3D
    {
    }
}