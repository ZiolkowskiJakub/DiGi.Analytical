using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Building.Interfaces
{
    public interface IBuildingBoundable3D : IBuildingGeometry3DObject
    {
        BoundingBox3D? GetBoundingBox();
    }
}