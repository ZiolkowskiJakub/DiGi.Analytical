using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Object.Core.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Base interface for building objects that have an associated geometry.
    /// </summary>
    public interface IBuildingGeometryObject : IBuildingGuidObject, IGeometryObject
    {
    }

    /// <summary>
    /// Interface for building objects with a specific type of geometry.
    /// </summary>
    /// <typeparam name="TGeometry">The type of geometry associated with the building object.</typeparam>
    public interface IBuildingGeometryObject<TGeometry> : IBuildingGeometry3DObject, IGeometryObject<TGeometry> where TGeometry : IGeometry
    {
    }
}