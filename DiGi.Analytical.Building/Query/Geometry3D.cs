using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        public static TGeometry3D? Geometry3D<TGeometry3D>(this IBuildingGeometry3DObject? buildingGeometry3DObject) where TGeometry3D : IGeometry3D
        {
            if (buildingGeometry3DObject == null)
            {
                return default;
            }

            IGeometry3D? geometry3D = null;

            if (buildingGeometry3DObject is IBuildingGeometry3DObject<ISurface3D>)
            {
                if (((IBuildingGeometryObject<ISurface3D>)buildingGeometry3DObject).Geometry is not IPolygonalFace3D polygonalFace3D)
                {
                    throw new System.NotImplementedException();
                }

                geometry3D = polygonalFace3D;
            }
            else if (buildingGeometry3DObject is IBuildingGeometry3DObject<IFace3D>)
            {
                if (((IBuildingGeometryObject<IFace3D>)buildingGeometry3DObject).Geometry is not IPolygonalFace3D polygonalFace3D)
                {
                    throw new System.NotImplementedException();
                }


                geometry3D = polygonalFace3D;
            }
            else if (buildingGeometry3DObject is IBuildingGeometry3DObject<ICurve3D>)
            {
                if (((IBuildingGeometryObject<ICurve3D>)buildingGeometry3DObject).Geometry is not ISegmentable3D)
                {
                    throw new System.NotImplementedException();
                }

                if (buildingGeometry3DObject is Classes.CurveWall wall)
                {
                    if (wall.GetSurface3D() is not IPolygonalFace3D polygonalFace3D)
                    {
                        throw new System.NotImplementedException();
                    }

                    geometry3D = polygonalFace3D;
                }
            }

            if(geometry3D is TGeometry3D geometry3D_Temp)
            {
                return geometry3D_Temp;
            }

            return default;
        }
    }
}