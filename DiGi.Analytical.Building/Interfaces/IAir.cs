using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IAir : IAbstractComponent
    {
    }

    public interface IAir<TGeometry3D> : IAbstractComponent<TGeometry3D> where TGeometry3D : IGeometry3D
    {
    }
}