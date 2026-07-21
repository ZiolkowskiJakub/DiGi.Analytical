using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts the 3D surface representation of the specified building component.
        /// <para>Surface based components (e.g. <see cref="SurfaceRoof"/>, <see cref="SurfaceWall"/>) return their geometry directly, face based components (e.g. <see cref="FaceFloor"/>) return their planar face and curve based walls (e.g. <see cref="CurveWall"/>) return the surface created by extruding the base curve by the wall vector.</para>
        /// </summary>
        /// <param name="component">The building component. This value can be null.</param>
        /// <returns>The <see cref="ISurface3D"/> representing the component, or null if the component has no supported surface geometry.</returns>
        public static ISurface3D? Surface3D(this IComponent? component)
        {
            if (component is IBuildingGeometryObject<ISurface3D> buildingGeometryObject_Surface3D)
            {
                return buildingGeometryObject_Surface3D.Geometry;
            }

            if (component is IBuildingGeometryObject<IFace3D> buildingGeometryObject_Face3D)
            {
                return buildingGeometryObject_Face3D.Geometry;
            }

            if (component is CurveWall<ICurve3D> curveWall)
            {
                return curveWall.GetSurface3D();
            }

            return null;
        }
    }
}