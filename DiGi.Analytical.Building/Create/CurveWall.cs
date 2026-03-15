using DiGi.Analytical.Building.Classes;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        public static CurveWall? CurveWall(this Segment3D? segment3D, double height, Vector3D? direction, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (segment3D == null || double.IsNaN(height) || direction == null)
            {
                return null;
            }

            double lenght = segment3D.Length;
            if (double.IsNaN(lenght) || lenght < tolerance)
            {
                return null;
            }

            if (direction.Similar(segment3D.Direction, tolerance))
            {
                return null;
            }

            return new CurveWall(segment3D, height, direction);
        }

        public static CurveWall? CurveWall(this Segment3D? segment3D, double height, double tolerance = Core.Constants.Tolerance.Distance)
        {
            return CurveWall(segment3D, height, Geometry.Spatial.Constants.Vector3D.WorldZ, tolerance);
        }
    }
}