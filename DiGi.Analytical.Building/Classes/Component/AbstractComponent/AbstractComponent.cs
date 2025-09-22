using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class AbstractComponent : Component, Interfaces.IComponent
    {
        public AbstractComponent(AbstractComponent? abstractComponent)
            : base(abstractComponent)
        {

        }

        public AbstractComponent(System.Guid guid, AbstractComponent? abstractComponent)
            : base(guid, abstractComponent)
        {

        }

        public AbstractComponent()
            : base()
        {

        }

        public AbstractComponent(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public AbstractComponent(System.Guid guid)
            : base(guid)
        {

        }

        [JsonInclude, JsonPropertyName("StructurePosition"), Description("Structure Position")]
        public StructurePosition StructurePosition { get; set; }
    }

    public abstract class AbstractComponent<T> : AbstractComponent, IAbstractComponent<T> where T : IGeometry3D
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        private readonly T? geometry;

        public AbstractComponent(T? geometry)
            : base()
        {

            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public AbstractComponent(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public AbstractComponent(AbstractComponent<T>? abstractComponent)
            : base(abstractComponent)
        {
            if (abstractComponent != null)
            {
                if (abstractComponent.geometry != null)
                {
                    geometry = abstractComponent.geometry.Clone<T>();
                }
            }
        }

        public AbstractComponent(AbstractComponent? abstractComponent, T? geometry)
            : base(abstractComponent)
        {
            this.geometry = geometry.Clone<T>();
        }

        public AbstractComponent(System.Guid guid, AbstractComponent<T>? abstractComponent)
            : base(guid, abstractComponent)
        {
            if (abstractComponent != null)
            {
                if (abstractComponent.geometry != null)
                {
                    geometry = abstractComponent.geometry.Clone<T>();
                }
            }
        }

        public AbstractComponent(System.Guid guid, T? geometry)
            : base(guid)
        {
            if(geometry is not null)
            {
                geometry = geometry.Clone<T>();
            }

        }

        [JsonIgnore]
        public T? Geometry
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
    }
}
