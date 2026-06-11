using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Triangulates the specified 3D building geometry object into a set of triangles.
        /// </summary>
        /// <param name="buildingGeometry3DObject">The building geometry object to triangulate.</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list of <see cref="Triangle3D"/> objects representing the triangulated geometry, or null if the object is null or cannot be triangulated.</returns>
        public static List<Triangle3D>? Triangulate(this IBuildingGeometry3DObject? buildingGeometry3DObject, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (buildingGeometry3DObject == null)
            {
                return null;
            }

            IPolygonalFace3D? polygonalFace3D = Geometry3D<IPolygonalFace3D>(buildingGeometry3DObject);
            if (polygonalFace3D == null)
            {
                return null;
            }

            return polygonalFace3D.Triangulate(tolerance);
        }
    }
}