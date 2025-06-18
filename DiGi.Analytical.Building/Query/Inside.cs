using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        public static bool Inside(this Sphere sphere, IBuildingGeometryObject buildingGeometryObject, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if (buildingGeometryObject == null || sphere == null)
            {
                return false;
            }

            List<Triangle3D> triagle3Ds = buildingGeometryObject.Triangulate(tolerance);
            if(triagle3Ds == null || triagle3Ds.Count == 0)
            {
                return false;
            }

            foreach(Triangle3D triangle3D in triagle3Ds)
            {
                if(!sphere.Inside(triangle3D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }
    }
}