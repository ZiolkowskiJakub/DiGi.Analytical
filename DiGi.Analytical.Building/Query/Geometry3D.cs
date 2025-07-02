using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        public static TGeometry3D Geometry3D<TGeometry3D>(this IBuildingGeometryObject buildingGeometryObject) where TGeometry3D : IGeometry3D
        {
            if (buildingGeometryObject == null)
            {
                return default;
            }

            IGeometry3D geometry3D = null;

            if (buildingGeometryObject is IBuildingGeometryObject<ISurface3D>)
            {
                IPolygonalFace3D polygonalFace3D = ((IBuildingGeometryObject<ISurface3D>)buildingGeometryObject).Geometry as IPolygonalFace3D;
                if (polygonalFace3D == null)
                {
                    throw new System.NotImplementedException();
                }

                geometry3D = polygonalFace3D;
            }
            else if (buildingGeometryObject is IBuildingGeometryObject<IFace3D>)
            {
                IPolygonalFace3D polygonalFace3D = ((IBuildingGeometryObject<IFace3D>)buildingGeometryObject).Geometry as IPolygonalFace3D;
                if (polygonalFace3D == null)
                {
                    throw new System.NotImplementedException();
                }


                geometry3D = polygonalFace3D;
            }
            else if (buildingGeometryObject is IBuildingGeometryObject<ICurve3D>)
            {
                ISegmentable3D segmentable3D = ((IBuildingGeometryObject<ICurve3D>)buildingGeometryObject).Geometry as ISegmentable3D;
                if (segmentable3D == null)
                {
                    throw new System.NotImplementedException();
                }

                if (buildingGeometryObject is Classes.CurveWall)
                {
                    IPolygonalFace3D polygonalFace3D = ((Classes.CurveWall)buildingGeometryObject).GetSurface3D() as IPolygonalFace3D;
                    if (polygonalFace3D == null)
                    {
                        throw new System.NotImplementedException();
                    }

                    geometry3D = polygonalFace3D;
                }
            }

            if(geometry3D is TGeometry3D)
            {
                return (TGeometry3D)geometry3D;
            }

            return default;
        }
    }
}