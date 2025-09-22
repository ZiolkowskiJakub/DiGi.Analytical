using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class PhysicalComponent : Component, IPhysicalComponent
    {
        public PhysicalComponent(PhysicalComponent? physicalComponent)
            : base(physicalComponent)
        {
            if (physicalComponent is not null)
            {
                physicalComponent.StructurePosition = StructurePosition;
            }
        }

        public PhysicalComponent(System.Guid guid, PhysicalComponent? physicalComponent)
            : base(guid, physicalComponent)
        {
            if(physicalComponent is not null)
            {
                physicalComponent.StructurePosition = StructurePosition;
            }
        }

        public PhysicalComponent()
            : base()
        {

        }

        public PhysicalComponent(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public PhysicalComponent(System.Guid guid)
            : base(guid)
        {

        }

        [JsonInclude, JsonPropertyName("StructurePosition"), Description("Structure Position")]
        public StructurePosition StructurePosition { get; set; }
    }

    public abstract class PhysicalComponent<T> : PhysicalComponent, IPhysicalComponent<T> where T : IGeometry3D
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        private readonly T? geometry;

        public PhysicalComponent(T? geometry)
            : base()
        {
            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public PhysicalComponent(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public PhysicalComponent(PhysicalComponent<T>? physicalComponent)
            : base(physicalComponent)
        {
            if (physicalComponent != null)
            {
                if (physicalComponent.geometry != null)
                {
                    geometry = physicalComponent.geometry.Clone<T>();
                }
            }
        }

        public PhysicalComponent(PhysicalComponent? physicalComponent, T? geometry)
            : base(physicalComponent)
        {
            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public PhysicalComponent(System.Guid guid, PhysicalComponent<T>? physicalComponent)
            : base(guid, physicalComponent)
        {
            if (physicalComponent != null)
            {
                if (physicalComponent.geometry != null)
                {
                    geometry = physicalComponent.geometry.Clone<T>();
                }
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
