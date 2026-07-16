using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for wall building components.
    /// </summary>
    public interface IWall : IPhysicalComponent
    {
    }

    /// <summary>
    /// Interface for wall components with a specific type of 3D geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry.</typeparam>
    public interface IWall<T> : IWall, IPhysicalComponent<T> where T : IGeometry3D
    {
    }
}