using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building objects defined by 3D curves.
    /// </summary>
    public interface IBuildingCurveObject : IBuildingGeometry3DObject
    {
    }

    /// <summary>
    /// Interface for building objects with a specific type of 3D curve.
    /// </summary>
    /// <typeparam name="TCurve3D">The type of the 3D curve.</typeparam>
    public interface IBuildingCurveObject<TCurve3D> : IBuildingCurveObject where TCurve3D : ICurve3D
    {
    }
}