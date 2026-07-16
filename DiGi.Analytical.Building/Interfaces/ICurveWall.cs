using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for walls defined by a 3D curve with an extrusion vector.
    /// </summary>
    /// <typeparam name="TCurve3D">The type of the 3D curve.</typeparam>
    public interface ICurveWall<TCurve3D> : IWall, IBuildingCurveObject<TCurve3D>, IComponent<TCurve3D> where TCurve3D : ICurve3D
    {
        /// <summary>
        /// Gets the extrusion direction vector of the curve wall.
        /// </summary>
        Vector3D? Vector { get; }
    }
}