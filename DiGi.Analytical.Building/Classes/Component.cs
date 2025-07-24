using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class Component : BuildingGeometry3DObject, Interfaces.IComponent
    {
        [JsonInclude, JsonPropertyName("StructurePosition"), Description("Structure Position")]
        public StructurePosition StructurePosition { get; set; }

        public Component(Component component)
            : base(component)
        {
            component.StructurePosition = StructurePosition;
        }

        public Component(System.Guid guid, Component component)
            : base(guid, component)
        {
            component.StructurePosition = StructurePosition;
        }

        public Component()
            : base()
        {

        }

        public Component(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Component(System.Guid guid)
            : base(guid)
        {

        }
    }

    public abstract class Component<T> : Component, IComponent<T> where T : IGeometry3D
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        private T geometry;

        [JsonIgnore]
        public T Geometry
        {
            get
            {
                if(geometry == null)
                {
                    return default;
                }

                return geometry.Clone<T>();
            }
        }

        public Component(T geometry)
            : base()
        {

            if(geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public Component(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Component(Component<T> component)
            : base(component)
        {
            if(component != null)
            {
                if(component.geometry != null)
                {
                    geometry = component.geometry.Clone<T>();
                }
            }
        }

        public Component(System.Guid guid, Component<T> component)
            : base(guid, component)
        {
            if (component != null)
            {
                if (component.geometry != null)
                {
                    geometry = component.geometry.Clone<T>();
                }
            }
        }
    }
}
