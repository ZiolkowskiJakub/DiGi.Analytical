using DiGi.Analytical.Building.Classes;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new <see cref="Classes.CurveWall"/> based on the provided segment, height, and direction.
        /// </summary>
        /// <param name="segment3D">The <see cref="Segment3D"/> that defines the base of the wall.</param>
        /// <param name="height">The height of the wall.</param>
        /// <param name="direction">The <see cref="Vector3D"/> representing the direction in which the wall is extruded.</param>
        /// <param name="tolerance">The distance tolerance used for geometric validation.</param>
        /// <returns>A new <see cref="Classes.CurveWall"/> instance if the parameters are valid; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Creates a curved wall based on a 3D segment using the world Z-axis as the default direction.
        /// </summary>
        /// <param name="segment3D">The 3D segment that defines the base of the curve wall.</param>
        /// <param name="height">The height of the wall to be created.</param>
        /// <param name="tolerance">The distance tolerance used for geometric validation.</param>
        /// <returns>A new <see cref="Classes.CurveWall"/> instance if the creation is successful; otherwise, <c>null</c>.</returns>
        public static CurveWall? CurveWall(this Segment3D? segment3D, double height, double tolerance = Core.Constants.Tolerance.Distance)
        {
            return CurveWall(segment3D, height, Geometry.Spatial.Constants.Vector3D.WorldZ, tolerance);
        }
    }
}