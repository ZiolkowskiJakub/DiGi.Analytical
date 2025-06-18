using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        public static Mesh3D Mesh3D(this IBuildingGeometryObject buildingGeometryObject, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if (buildingGeometryObject == null)
            {
                return null;
            }

            List<Triangle3D> triangle3Ds = buildingGeometryObject.Triangulate(tolerance);
            if (triangle3Ds == null || triangle3Ds.Count == 0)
            {
                return null;
            }

            return Geometry.Spatial.Create.Mesh3D(triangle3Ds);
        }
    }
}