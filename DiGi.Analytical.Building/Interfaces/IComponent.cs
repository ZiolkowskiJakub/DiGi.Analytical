using DiGi.Analytical.Building.Enums;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IComponent : IBuildingGeometry3DObject, IConstructable
    {
        StructurePosition StructurePosition { get; }
    }

    public interface IComponent<T> : IComponent, IBuildingGeometryObject<T> where T: IGeometry3D
    {

    }
}
