using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for terrain elements surrounding a building, such as ground planes or surveyed ground surfaces.
    /// </summary>
    public interface ITerrain : IBuildingGeometry3DObject
    {
    }

    /// <summary>
    /// Interface for terrain elements with a specific type of 3D geometry.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry.</typeparam>
    public interface ITerrain<T> : ITerrain, IBuildingGeometry3DObject<T> where T : IGeometry3D
    {
    }
}
