using DiGi.Analytical.Building.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class PhysicalComponentConstruction : BuildingNamedObject, IPhysicalComponentConstruction
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string? description;

        public PhysicalComponentConstruction()
            : base()
        {
        }

        public PhysicalComponentConstruction(PhysicalComponentConstruction? componentConstruction)
            : base(componentConstruction)
        {
            if (componentConstruction is not null)
            {
            }
        }

        public PhysicalComponentConstruction(System.Guid guid, PhysicalComponentConstruction? componentConstruction)
            : base(guid, componentConstruction)
        {
            if (componentConstruction is not null)
            {
            }
        }

        public PhysicalComponentConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public string? Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }

    public abstract class ComponentConstruction<TConstructable> : PhysicalComponentConstruction, IPhysicalComponentConstruction<TConstructable> where TConstructable : IConstructable
    {
        public ComponentConstruction()
            : base()
        {
        }

        public ComponentConstruction(ComponentConstruction<TConstructable>? componentConstruction)
            : base(componentConstruction)
        {
        }

        public ComponentConstruction(System.Guid guid, ComponentConstruction<TConstructable>? componentConstruction)
            : base(guid, componentConstruction)
        {
        }

        public ComponentConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}