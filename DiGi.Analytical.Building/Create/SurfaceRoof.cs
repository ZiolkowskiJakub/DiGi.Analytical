using DiGi.Analytical.Building.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="SurfaceRoof"/> from the specified polygonal face, provided its area is valid and exceeds the given tolerance.
        /// </summary>
        /// <param name="polygonalFace3D">The polygonal face to be converted into a surface roof.</param>
        /// <param name="tolerance">The minimum area threshold required to create the surface roof. Defaults to <see cref="Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>A new <see cref="SurfaceRoof"/> instance if the face is not null and its area is greater than or equal to the tolerance; otherwise, <c>null</c>.</returns>
        public static SurfaceRoof? SurfaceRoof(this IPolygonalFace3D? polygonalFace3D, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            double area = polygonalFace3D.GetArea();
            if (double.IsNaN(area) || area < tolerance)
            {
                return null;
            }

            return new SurfaceRoof(polygonalFace3D);
        }
    }
}