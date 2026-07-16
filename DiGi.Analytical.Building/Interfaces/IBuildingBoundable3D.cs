using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Building.Interfaces
{
    /// <summary>
    /// Interface for building objects that can compute their 3D bounding box.
    /// </summary>
    public interface IBuildingBoundable3D : IBuildingGeometry3DObject
    {
        /// <summary>
        /// Computes the 3D bounding box of the building object.
        /// </summary>
        /// <returns>The <see cref="BoundingBox3D"/> if available; otherwise, <c>null</c>.</returns>
        BoundingBox3D? GetBoundingBox();
    }
}