using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        public static TGeometry3D Geometry3D<TGeometry3D>(this IBuildingGeometry3DObject buildingGeometry3DObject) where TGeometry3D : IGeometry3D
        {
            if (buildingGeometry3DObject == null)
            {
                return default;
            }

            IGeometry3D geometry3D = null;

            if (buildingGeometry3DObject is IBuildingGeometry3DObject<ISurface3D>)
            {
                IPolygonalFace3D polygonalFace3D = ((IBuildingGeometryObject<ISurface3D>)buildingGeometry3DObject).Geometry as IPolygonalFace3D;
                if (polygonalFace3D == null)
                {
                    throw new System.NotImplementedException();
                }

                geometry3D = polygonalFace3D;
            }
            else if (buildingGeometry3DObject is IBuildingGeometry3DObject<IFace3D>)
            {
                IPolygonalFace3D polygonalFace3D = ((IBuildingGeometryObject<IFace3D>)buildingGeometry3DObject).Geometry as IPolygonalFace3D;
                if (polygonalFace3D == null)
                {
                    throw new System.NotImplementedException();
                }


                geometry3D = polygonalFace3D;
            }
            else if (buildingGeometry3DObject is IBuildingGeometry3DObject<ICurve3D>)
            {
                ISegmentable3D segmentable3D = ((IBuildingGeometryObject<ICurve3D>)buildingGeometry3DObject).Geometry as ISegmentable3D;
                if (segmentable3D == null)
                {
                    throw new System.NotImplementedException();
                }

                if (buildingGeometry3DObject is Classes.CurveWall)
                {
                    IPolygonalFace3D polygonalFace3D = ((Classes.CurveWall)buildingGeometry3DObject).GetSurface3D() as IPolygonalFace3D;
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