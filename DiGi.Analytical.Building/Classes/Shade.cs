using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class Shade<T> : BuildingGeometryObject<T>, IShade<T> where T : IGeometry3D
    {
        public Shade(T geometry)
            :base(geometry)
        {

        }

        public Shade(Shade<T> shade)
            : base(shade)
        {

        }

        public Shade(System.Guid guid, Shade<T> shade)
            : base(guid, shade)
        {

        }

        public Shade(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
