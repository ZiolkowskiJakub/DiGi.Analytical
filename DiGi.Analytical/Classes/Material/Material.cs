using DiGi.Analytical.Interfaces;
using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    public abstract class Material : GuidObject, IMaterial
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string? description;

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string? name;
        
        public Material(string? name)
            : base()
        {
            this.name = name;
        }

        public Material(Material? material)
            :base(material)
        {
            if(material != null)
            {
                name = material.name;
            }
        }

        public Material(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
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

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        public string? Name
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
