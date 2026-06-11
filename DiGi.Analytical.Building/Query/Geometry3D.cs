using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts the 3D geometry from the specified building geometry object as a specific type.
        /// </summary>
        /// <typeparam name="TGeometry3D">The type of 3D geometry to return, which must implement <see cref="IGeometry3D"/>.</typeparam>
        /// <param name="buildingGeometry3DObject">The building geometry object from which the 3D geometry is extracted.</param>
        /// <returns>The extracted 3D geometry of type <typeparamref name="TGeometry3D"/>, or <see langword="null"/> if the object is null or the geometry cannot be converted.</returns>
        public static TGeometry3D? Geometry3D<TGeometry3D>(this IBuildingGeometry3DObject? buildingGeometry3DObject) where TGeometry3D : IGeometry3D
        {
            if (buildingGeometry3DObject == null)
            {
                return default;
            }

            IGeometry3D? geometry3D = (buildingGeometry3DObject as dynamic).Geometry;
            if (geometry3D is null)
            {
                return default;
            }

            List<TGeometry3D>? geometries = Geometry.Spatial.Query.Convert<TGeometry3D>(geometry3D);
            if (geometries is null)
            {
                return default;
            }

            if (geometries.Count > 1)
            {
                throw new System.NotImplementedException();
            }

            return geometries[0];

            //if (buildingGeometry3DObject is IBuildingGeometry3DObject<ISurface3D>)
            //{
            //    if (((IBuildingGeometryObject<ISurface3D>)buildingGeometry3DObject).Geometry is not IPolygonalFace3D polygonalFace3D)
            //    {
            //        throw new System.NotImplementedException();
            //    }

            //    geometry3D = polygonalFace3D;
            //}
            //else if (buildingGeometry3DObject is IBuildingGeometry3DObject<IFace3D>)
            //{
            //    if (((IBuildingGeometryObject<IFace3D>)buildingGeometry3DObject).Geometry is not IPolygonalFace3D polygonalFace3D)
            //    {
            //        throw new System.NotImplementedException();
            //    }

            //    geometry3D = polygonalFace3D;
            //}
            //else if (buildingGeometry3DObject is IBuildingGeometry3DObject<ICurve3D>)
            //{
            //    if (((IBuildingGeometryObject<ICurve3D>)buildingGeometry3DObject).Geometry is not ISegmentable3D)
            //    {
            //        throw new System.NotImplementedException();
            //    }

            //    if (buildingGeometry3DObject is Classes.CurveWall wall)
            //    {
            //        if (wall.GetSurface3D() is not IPolygonalFace3D polygonalFace3D)
            //        {
            //            throw new System.NotImplementedException();
            //        }

            //        geometry3D = polygonalFace3D;
            //    }
            //}

            //if(geometry3D is TGeometry3D geometry3D_Temp)
            //{
            //    return geometry3D_Temp;
            //}

            //return default;
        }
    }
}