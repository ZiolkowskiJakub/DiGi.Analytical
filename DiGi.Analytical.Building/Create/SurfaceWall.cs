using DiGi.Analytical.Building.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        public static SurfaceWall SurfaceWall(this IPolygonalFace3D polygonalFace3D, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if(polygonalFace3D == null)
            {
                return null;
            }

            double area = polygonalFace3D.GetArea();
            if(double.IsNaN(area) || area < tolerance)
            {
                return null;
            }

            return new SurfaceWall(polygonalFace3D);
        }
    }
}
