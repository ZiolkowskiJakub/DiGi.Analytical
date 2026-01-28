using DiGi.Geometry.Spatial.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class Component : BuildingGeometry3DObject, Interfaces.IComponent
    {
        public Component(Component? component)
            : base(component)
        {
        }

        public Component(System.Guid guid, Component? component)
            : base(guid, component)
        {
        }

        public Component()
            : base()
        {
        }

        public Component(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public Component(System.Guid guid)
            : base(guid)
        {
        }

        public abstract BoundingBox3D? GetBoundingBox();
    }
}