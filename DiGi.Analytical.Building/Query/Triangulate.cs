using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        public static List<Triangle3D> Triangulate(this IBuildingGeometryObject buildingGeometryObject, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if (buildingGeometryObject == null)
            {
                return null;
            }

            if (buildingGeometryObject is IBuildingGeometryObject<ISurface3D>)
            {
                IPolygonalFace3D polygonalFace3D = ((IBuildingGeometryObject<ISurface3D>)buildingGeometryObject).Geometry as IPolygonalFace3D;
                if (polygonalFace3D == null)
                {
                    throw new System.NotImplementedException();
                }

                return polygonalFace3D.Triangulate(tolerance);
            }

            if (buildingGeometryObject is IBuildingGeometryObject<IFace3D>)
            {
                IPolygonalFace3D polygonalFace3D = ((IBuildingGeometryObject<IFace3D>)buildingGeometryObject).Geometry as IPolygonalFace3D;
                if (polygonalFace3D == null)
                {
                    throw new System.NotImplementedException();
                }

                return polygonalFace3D.Triangulate(tolerance);
            }

            if (buildingGeometryObject is IBuildingGeometryObject<ICurve3D>)
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

                    return polygonalFace3D.Triangulate(tolerance);
                }
            }

            throw new System.NotImplementedException();
        }
    }
}