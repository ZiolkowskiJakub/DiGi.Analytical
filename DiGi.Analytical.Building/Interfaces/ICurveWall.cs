using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface ICurveWall<TCurve3D> : IWall, IBuildingCurveObject<TCurve3D>, IComponent<TCurve3D> where TCurve3D : ICurve3D
    {
        Vector3D Vector { get; }
    }
}
