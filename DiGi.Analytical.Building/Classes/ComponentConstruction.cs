using DiGi.Analytical.Building.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class ComponentConstruction : BuildingNamedObject, IComponentConstruction
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string? description;
        
        public ComponentConstruction()
            : base()
        {
        }

        public ComponentConstruction(ComponentConstruction? componentConstruction)
            : base(componentConstruction)
        {
            if (componentConstruction is not null)
            {

            }
        }

        public ComponentConstruction(System.Guid guid, ComponentConstruction? componentConstruction)
            : base(guid, componentConstruction)
        {
            if (componentConstruction is not null)
            {

            }
        }

        public ComponentConstruction(JsonObject? jsonObject)
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

    public abstract class ComponentConstruction<TConstructable> : ComponentConstruction, IComponentConstruction<TConstructable> where TConstructable : IConstructable
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
