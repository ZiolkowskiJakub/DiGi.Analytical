using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class CurveWall<TCurve3D> : Wall<TCurve3D>, ICurveWall<TCurve3D> where TCurve3D : ICurve3D
    {
        [JsonInclude, JsonPropertyName("Vector"), Description("Vector")]
        private readonly Vector3D? vector;

        public CurveWall(TCurve3D? curve3D, double height, Vector3D? direction)
                    : base(curve3D)
        {
            vector = direction?.Unit * height;
        }

        public CurveWall(TCurve3D? curve3D, double height)
            : base(curve3D)
        {
            vector = DiGi.Geometry.Spatial.Constans.Vector3D.WorldZ * height;
        }

        public CurveWall(CurveWall<TCurve3D>? curveWall)
            : base(curveWall)
        {
            if (curveWall != null)
            {
                vector = curveWall.vector == null ? null : new Vector3D(curveWall.vector);
            }
        }

        public CurveWall(System.Guid guid, CurveWall<TCurve3D>? curveWall)
            : base(guid, curveWall)
        {
            if (curveWall != null)
            {
                vector = Core.Query.Clone(curveWall.vector);
            }
        }

        public CurveWall(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public Vector3D? Vector
        {
            get
            {
                return vector == null ? null : new Vector3D(vector);
            }

            set
            {
                Vector = value;
            }
        }
        
        public ISurface3D? GetSurface3D()
        {
            if(vector == null)
            {
                return null;
            }

            ICurve3D? curve3D = Geometry;
            if (curve3D == null)
            {
                return null;
            }

            if (curve3D is not Segment3D segment3D)
            {
                throw new System.NotImplementedException();
            }

            if (segment3D.Start is not Point3D point3D_1)
            {
                return null;
            }

            if (segment3D.End is not Point3D point3D_2)
            {
                return null;
            }

            if (segment3D.End.GetMoved(vector) is not Point3D point3D_3)
            {
                return null;
            }

            if (segment3D.Start.GetMoved(vector) is not Point3D point3D_4)
            {
                return null;
            }

            Plane plane = new(point3D_1, point3D_2, point3D_3);

            return new PolygonalFace3D(plane, DiGi.Geometry.Planar.Create.PolygonalFace2D(new Polygon2D([plane.Convert(point3D_1)!, plane.Convert(point3D_2)!, plane.Convert(point3D_3)!, plane.Convert(point3D_4)!])));
        }

        public override BoundingBox3D? GetBoundingBox()
        {
            return GetSurface3D()?.GetBoundingBox();
        }
    }

    public class CurveWall : CurveWall<ICurve3D>
    {
        public CurveWall(ICurve3D? curve3D, double height, Vector3D? direction)
            : base(curve3D, height, direction)
        {

        }

        public CurveWall(ICurve3D? curve3D, double height)
            : base(curve3D, height)
        {

        }

        public CurveWall(CurveWall? curveWall)
            : base(curveWall)
        {

        }

        public CurveWall(System.Guid guid, CurveWall<ICurve3D>?curveWall)
            : base(guid, curveWall)
        {

        }

        public CurveWall(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }
    }
}
