using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for air-based building components.
    /// </summary>
    public interface IAir : IAbstractComponent
    {
    }

    /// <summary>
    /// Interface for air-based components with a specific type of 3D geometry.
    /// </summary>
    /// <typeparam name="TGeometry3D">The type of the 3D geometry.</typeparam>
    public interface IAir<TGeometry3D> : IAir, IAbstractComponent<TGeometry3D> where TGeometry3D : IGeometry3D
    {
    }
}