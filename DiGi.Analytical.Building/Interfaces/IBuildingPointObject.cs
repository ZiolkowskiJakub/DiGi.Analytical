using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building objects that have a point-based 3D geometry.
    /// </summary>
    public interface IBuildingPointObject : IBuildingGeometryObject<Point3D>, IPoint3DObject
    {
    }
}