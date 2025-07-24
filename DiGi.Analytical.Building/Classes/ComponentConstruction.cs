using DiGi.Analytical.Building.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class ComponentConstruction : BuildingNamedObject, IComponentConstruction
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string description;

        [JsonInclude, JsonPropertyName("Structure")]
        private IStructure structure;
        public ComponentConstruction(IStructure structure)
            : base()
        {
            structure = Core.Query.Clone(structure);
        }

        public ComponentConstruction(ComponentConstruction componentConstruction)
            : base(componentConstruction)
        {
            if (componentConstruction != null)
            {
                structure = Core.Query.Clone(componentConstruction.structure);
            }
        }

        public ComponentConstruction(System.Guid guid, ComponentConstruction componentConstruction)
            : base(guid, componentConstruction)
        {
            if (componentConstruction != null)
            {
                structure = Core.Query.Clone(componentConstruction.structure);
            }
        }

        public ComponentConstruction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public string Description
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

        [JsonIgnore]
        public IStructure Structure
        {
            get
            {
                return structure;
            }

            set
            {
                structure = value;
            }
        }
    }

    public abstract class ComponentConstruction<TConstructable> : ComponentConstruction, IComponentConstruction<TConstructable> where TConstructable : IConstructable
    {
        public ComponentConstruction(IStructure structure)
            : base(structure)
        {

        }

        public ComponentConstruction(ComponentConstruction<TConstructable> componentConstruction)
            : base(componentConstruction)
        {
        }

        public ComponentConstruction(System.Guid guid, ComponentConstruction<TConstructable> componentConstruction)
            : base(guid, componentConstruction)
        {

        }

        public ComponentConstruction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
