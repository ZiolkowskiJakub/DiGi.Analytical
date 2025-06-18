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
    public class CurveWall : Wall<ICurve3D>, ICurveWall
    {
        [JsonIgnore]
        private Vector3D vector { get; set; }

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

        public CurveWall(ICurve3D curve3D, double height, Vector3D direction)
            : base(curve3D)
        {
            vector = direction.Unit * height;
        }

        public CurveWall(ICurve3D curve3D, double height)
            : base(curve3D)
        {
            vector = DiGi.Geometry.Spatial.Constans.Vector3D.WorldZ * height;
        }

        public CurveWall(CurveWall curveWall)
            : base(curveWall)
        {
            if(curveWall != null)
            {
                vector = curveWall.vector == null ? null : new Vector3D(curveWall.vector);
            }
        }

        public CurveWall(System.Guid guid, CurveWall curveWall)
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

            Plane plane = new Plane(point3D_1, point3D_2, point3D_3);

            return new PolygonalFace3D(plane, DiGi.Geometry.Planar.Create.PolygonalFace2D(new Polygon2D(new Point2D[] { plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4) })));
        }
    }
}
