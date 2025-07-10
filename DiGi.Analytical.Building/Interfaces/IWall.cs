using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IWall : IComponent
    {

    }

    public interface IWall<T> : IWall, IComponent<T> where T : IGeometry3D
    {

    }
}
