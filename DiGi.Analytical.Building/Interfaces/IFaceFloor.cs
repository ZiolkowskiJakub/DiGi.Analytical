using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for floors defined by a 3D face geometry.
    /// </summary>
    public interface IFaceFloor : IFloor, IBuildingFaceObject, IComponent<IFace3D>
    {
    }
}