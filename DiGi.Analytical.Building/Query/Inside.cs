using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        public static bool Inside(this Sphere sphere, IBuildingGeometry3DObject buildingGeometry3DObject, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if (buildingGeometry3DObject == null || sphere == null)
            {
                return false;
            }

            List<Triangle3D> triagle3Ds = buildingGeometry3DObject.Triangulate(tolerance);
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