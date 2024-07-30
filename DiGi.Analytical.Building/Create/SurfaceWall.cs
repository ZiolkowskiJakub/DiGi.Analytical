using DiGi.Analytical.Building.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        public static SurfaceWall SurfaceWall(this VolatilePolygonalFace3D volatilePolygonalFace3D, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if(volatilePolygonalFace3D == null)
            {
                return null;
            }

            double area = volatilePolygonalFace3D.GetArea();
            if(double.IsNaN(area) || area < tolerance)
            {
                return null;
            }

            return new SurfaceWall((PolygonalFace3D)volatilePolygonalFace3D);
        }
    }
}
