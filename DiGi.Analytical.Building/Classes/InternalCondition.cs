using DiGi.Analytical.Building.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class InternalCondition : BuildingObject, IInternalCondition
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string description;

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string name;
        
        public InternalCondition(string name)
            : base()
        {
            this.name = name;
        }

        public InternalCondition(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public InternalCondition(InternalCondition internalCondition)
            : base(internalCondition)
        {
            if (internalCondition != null)
            {
                name = internalCondition.name;
                description = internalCondition.description;
            }
        }

        public InternalCondition(System.Guid guid, InternalCondition internalCondition)
            : base(guid, internalCondition)
        {
            if (internalCondition != null)
            {
                name = internalCondition.name;
                description = internalCondition.description;
            }
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
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
