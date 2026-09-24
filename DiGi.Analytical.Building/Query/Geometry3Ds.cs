using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Object.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts the 3D geometry from the specified building geometry object and converts it to every representation of the requested type.
        /// <para>A conversion can yield several results: a face requested as <see cref="IPolygonal3D"/> gives its outer edge followed by each hole, and a polygon requested as <see cref="Segment3D"/> gives its segments. Requests for a face, plane or the geometry itself give at most one.</para>
        /// </summary>
        /// <typeparam name="TGeometry3D">The type of 3D geometry to return, which must implement <see cref="IGeometry3D"/>.</typeparam>
        /// <param name="buildingGeometry3DObject">The building geometry object from which the 3D geometry is extracted.</param>
        /// <returns>Every converted geometry of type <typeparamref name="TGeometry3D"/>; an empty list when the geometry cannot be represented as that type; <see langword="null"/> if the object is null or has no geometry.</returns>
        public static List<TGeometry3D>? Geometry3Ds<TGeometry3D>(this IBuildingGeometry3DObject? buildingGeometry3DObject) where TGeometry3D : IGeometry3D
        {
            if (buildingGeometry3DObject is null)
            {
                return null;
            }

            IGeometry3D? geometry3D = buildingGeometry3DObject switch
            {
                CurveWall<ICurve3D> curveWall => curveWall.GetSurface3D(),
                IGeometryObject<IFace3D> geometryObject => geometryObject.Geometry,
                IGeometryObject<ISurface3D> geometryObject => geometryObject.Geometry,
                IGeometryObject<Plane> geometryObject => geometryObject.Geometry,
                IGeometryObject<Point3D> geometryObject => geometryObject.Geometry,
                // Wall<T>, Air<T>, Shade<T> and Terrain<T> are public open generics, so a caller can close them over any geometry type.
                _ => (buildingGeometry3DObject as dynamic).Geometry,
            };

            if (geometry3D is null)
            {
                return null;
            }

            return Geometry.Spatial.Query.Convert<TGeometry3D>(geometry3D) ?? [];
        }
    }
}
