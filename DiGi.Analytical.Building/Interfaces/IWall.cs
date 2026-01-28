using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IWall : IPhysicalComponent
    {
    }

    public interface IWall<T> : IWall, IPhysicalComponent<T> where T : IGeometry3D
    {
    }
}