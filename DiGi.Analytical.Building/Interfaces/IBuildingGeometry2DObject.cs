using DiGi.Geometry.Object.Planar.Interfaces;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building objects that have 2D geometry.
    /// </summary>
    public interface IBuildingGeometry2DObject : IBuildingGeometryObject, IGeometry2DObject
    {
    }

    /// <summary>
    /// Interface for building objects with a specific type of 2D geometry.
    /// </summary>
    /// <typeparam name="T">The specific type of 2D geometry.</typeparam>
    public interface IBuildingGeometry2DObject<T> : IBuildingGeometryObject<T>, IBuildingGeometry2DObject, IGeometry2DObject<T> where T : IGeometry2D
    {
    }
}