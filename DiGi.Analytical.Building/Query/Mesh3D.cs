using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Creates a <see cref="T:DiGi.Geometry.Spatial.Classes.Mesh3D"/> from the specified building geometry object by triangulating it.
        /// </summary>
        /// <param name="buildingGeometryObject">The building geometry object to convert into a mesh.</param>
        /// <param name="tolerance">The distance tolerance used during the triangulation process.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Spatial.Classes.Mesh3D"/> representing the triangulated geometry, or <c>null</c> if the object is null or cannot be triangulated.</returns>
        public static Mesh3D? Mesh3D(this IBuildingGeometry3DObject? buildingGeometryObject, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (buildingGeometryObject == null)
            {
                return null;
            }

            List<Triangle3D>? triangle3Ds = buildingGeometryObject.Triangulate(tolerance);
            if (triangle3Ds == null || triangle3Ds.Count == 0)
            {
                return null;
            }

            return Geometry.Spatial.Create.Mesh3D(triangle3Ds);
        }
    }
}