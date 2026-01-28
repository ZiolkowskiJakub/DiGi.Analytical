using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class Floor<T> : PhysicalComponent<T>, IFloor where T : IGeometry3D
    {
        public Floor(T? geometry)
            : base(geometry)
        {
        }

        public Floor(Floor<T>? floor)
            : base(floor)
        {
        }

        public Floor(System.Guid guid, Floor<T>? floor)
            : base(guid, floor)
        {
        }

        public Floor(IFloor? floor, T? geometry)
            : base(floor as PhysicalComponent, geometry)
        {
        }

        public Floor(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}