using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building objects that have 3D geometry.
    /// </summary>
    public interface IBuildingGeometry3DObject : IBuildingGeometryObject, IGeometry3DObject
    {
    }

    /// <summary>
    /// Interface for building objects with a specific type of 3D geometry.
    /// </summary>
    /// <typeparam name="T">The specific type of 3D geometry.</typeparam>
    public interface IBuildingGeometry3DObject<T> : IBuildingGeometryObject<T>, IBuildingGeometry3DObject, IGeometry3DObject<T> where T : IGeometry3D
    {
    }
}