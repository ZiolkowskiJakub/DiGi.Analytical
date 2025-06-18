using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class Roof<T> : Component<T>, IRoof where T : ISurface3D
    {
        public Roof(T geometry)
            :base(geometry)
        {

        }

        public Roof(Roof<T> roof)
            : base(roof)
        {

        }

        public Roof(System.Guid guid, Roof<T> roof)
            : base(guid, roof)
        {

        }

        public Roof(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
