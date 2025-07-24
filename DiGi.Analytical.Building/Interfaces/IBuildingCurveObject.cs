using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IBuildingCurveObject : IBuildingGeometry3DObject
    {

    }

    public interface IBuildingCurveObject<TCurve3D> : IBuildingCurveObject where TCurve3D : ICurve3D
    {

    }
}
