using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building components that are both boundable in 3D and constructable.
    /// </summary>
    public interface IComponent : IBuildingBoundable3D, IConstructable
    {
    }

    /// <summary>
    /// Interface for building components with a specific type of 3D geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry.</typeparam>
    public interface IComponent<T> : IComponent, IBuildingGeometryObject<T> where T : IGeometry3D
    {
    }
}