using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class Air<T> : AbstractComponent<T>, IAir<T> where T : IGeometry3D
    {
        public Air(T? geometry)
            : base(geometry)
        {
        }

        public Air(Air<T>? air)
            : base(air)
        {
        }

        public Air(Guid guid, Air<T>? air)
            : base(guid, air)
        {
        }

        public Air(IAir? air, T? geometry)
            : base(air as AbstractComponent, geometry)
        {
        }

        public Air(Guid guid, T? geometry)
            : base(guid, geometry)
        {
        }

        public Air(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}