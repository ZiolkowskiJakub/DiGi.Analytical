using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        public static List<Triangle3D> Triangulate(this IBuildingGeometry3DObject buildingGeometry3DObject, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if (buildingGeometry3DObject == null)
            {
                return null;
            }

            IPolygonalFace3D polygonalFace3D = Geometry3D<IPolygonalFace3D>(buildingGeometry3DObject);
            if(polygonalFace3D == null)
            {
                return null;
            }

            return polygonalFace3D.Triangulate(tolerance);
        }
    }
}