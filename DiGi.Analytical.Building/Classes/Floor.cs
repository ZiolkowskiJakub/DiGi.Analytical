using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class Floor<T> : Component<T>, IFloor where T : IGeometry3D
    {
        public Floor(T geometry)
            :base(geometry)
        {

        }

        public Floor(Floor<T> wall)
            : base(wall)
        {

        }

        public Floor(System.Guid guid, Floor<T> floor)
            : base(guid, floor)
        {

        }

        public Floor(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
