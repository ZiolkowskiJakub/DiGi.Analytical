using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class CurveWall : Wall<ICurve3D>, ICurveWall
    {
        [JsonInclude, JsonPropertyName("Height"), Description("Height")]
        public double Height { get; set; }

        [JsonInclude, JsonPropertyName("Direction"), Description("Direction")]
        private Vector3D direction { get; set; }

        [JsonIgnore]
        public Vector3D Direction
        {
            get
            {
                return direction == null ? null : new Vector3D(direction);
            }

            set
            {
                direction = DiGi.Geometry.Spatial.Create.Vector3D(value, true);
            }
        }

        public CurveWall(ICurve3D curve3D, double height, Vector3D direction)
            : base(curve3D)
        {
            Height = height;
            Direction = direction;
        }

        public CurveWall(ICurve3D curve3D, double height)
            : base(curve3D)
        {
            Height = height;
        }

        public CurveWall(CurveWall curveWall)
            : base(curveWall)
        {
            if(curveWall != null)
            {
                Height = curveWall.Height;
                Direction = curveWall.direction;
            }
        }

        public CurveWall(System.Guid guid, CurveWall curveWall)
            : base(guid, curveWall)
        {
            if (curveWall != null)
            {
                Height = curveWall.Height;
                Direction = curveWall.direction;
            }
        }

        public CurveWall(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
