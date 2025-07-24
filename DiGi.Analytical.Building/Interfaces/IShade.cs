using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IShade : IBuildingGeometry3DObject
    {

    }

    public interface IShade<T> : IShade, IBuildingGeometryObject<T> where T : IGeometry3D
    {

    }
}
