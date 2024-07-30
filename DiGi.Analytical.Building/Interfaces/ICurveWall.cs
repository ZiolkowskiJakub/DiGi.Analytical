using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface ICurveWall : IWall, IBuildingCurveObject, IComponent<ICurve3D>
    {
        double Height { get; }
        
        Vector3D Direction { get; }
    }
}
