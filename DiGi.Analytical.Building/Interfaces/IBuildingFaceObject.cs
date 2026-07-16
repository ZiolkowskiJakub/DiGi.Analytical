using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building objects that have a 3D face geometry.
    /// </summary>
    public interface IBuildingFaceObject : IBuildingGeometryObject<IFace3D>
    {
    }
}