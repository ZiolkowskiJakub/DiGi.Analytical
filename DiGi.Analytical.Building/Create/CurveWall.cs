using DiGi.Analytical.Building.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        public static CurveWall CurveWall(this VolatileSegment3D volatileSegment3D, double height, Vector3D direction, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if (volatileSegment3D == null || double.IsNaN(height) || direction == null)
            {
                return null;
            }

            double lenght = volatileSegment3D.GetLength();
            if (double.IsNaN(lenght) || lenght < tolerance)
            {
                return null;
            }

            Segment3D segment3D = volatileSegment3D.Geometry;

            if(direction.Similar(segment3D.Direction, tolerance))
            {
                return null;
            }

            return new CurveWall(segment3D, height, direction);
        }

        public static CurveWall CurveWall(this VolatileSegment3D volatileSegment3D, double height, double tolerance = Core.Constans.Tolerance.Distance)
        {
            return CurveWall(volatileSegment3D, height, Constans.Vector3D.WorldZ, tolerance);
        }
    }
}
