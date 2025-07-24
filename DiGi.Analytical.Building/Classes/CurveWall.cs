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
        public CurveWall(TCurve3D curve3D, double height, Vector3D direction)
            : base(curve3D)
        {
            vector = direction.Unit * height;
        }

        public CurveWall(TCurve3D curve3D, double height)
            : base(curve3D)
        {
            vector = DiGi.Geometry.Spatial.Constans.Vector3D.WorldZ * height;
        }

        public CurveWall(CurveWall<TCurve3D> curveWall)
            : base(curveWall)
        {
            if (curveWall != null)
            {
                vector = curveWall.vector == null ? null : new Vector3D(curveWall.vector);
            }
        }

        public CurveWall(System.Guid guid, CurveWall<TCurve3D> curveWall)
            : base(guid, curveWall)
        {
            if (curveWall != null)
            {
                vector = Core.Query.Clone(curveWall.vector);
            }
        }

        public CurveWall(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Vector"), Description("Vector")]
        public Vector3D Vector
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

        [JsonIgnore]
        private Vector3D vector { get; set; }
        
        public ISurface3D GetSurface3D()
        {
            if(vector == null)
            {
                return null;
            }

            ICurve3D curve3D = Geometry;
            if (curve3D == null)
            {
                return null;
            }

            Segment3D segment3D = curve3D as Segment3D;
            if(segment3D == null)
            {
                throw new System.NotImplementedException();
            }

            Point3D point3D_1 = segment3D.Start;
            Point3D point3D_2 = segment3D.End;
            Point3D point3D_3 = segment3D.End.GetMoved(vector);
            Point3D point3D_4 = segment3D.Start.GetMoved(vector);

            Geometry.Spatial.Classes.Plane plane = new Geometry.Spatial.Classes.Plane(point3D_1, point3D_2, point3D_3);

            return new PolygonalFace3D(plane, DiGi.Geometry.Planar.Create.PolygonalFace2D(new Polygon2D(new Point2D[] { plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4) })));
        }
    }

    public class CurveWall : CurveWall<ICurve3D>
    {
        public CurveWall(ICurve3D curve3D, double height, Vector3D direction)
            : base(curve3D, height, direction)
        {

        }

        public CurveWall(ICurve3D curve3D, double height)
            : base(curve3D, height)
        {

        }

        public CurveWall(CurveWall curveWall)
            : base(curveWall)
        {

        }

        public CurveWall(System.Guid guid, CurveWall<ICurve3D> curveWall)
            : base(guid, curveWall)
        {

        }

        public CurveWall(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
