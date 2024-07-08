using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IFloor : IBuildingGeometryObject, IComponent
    {

    }

    public interface IFaceFloor : IFloor, IBuildingFaceObject, IComponent<IFace3D>
    {

    }
}
