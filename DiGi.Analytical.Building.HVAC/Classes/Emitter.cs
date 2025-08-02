using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public abstract class Emitter : ParametrizedObject, IHVACNamedObject
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        public string Description { get; set; }

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        public string Name { get; set; }

        [JsonInclude, JsonPropertyName("RadiantProportion"), Description("RadiantProportion [0-1]")]
        public Factor RadiantProportion { get; set; }

        [JsonInclude, JsonPropertyName("ViewCoefficient"), Description("ViewCoefficient [0-1]")]
        public Factor ViewCoefficient { get; set; }

        [JsonInclude, JsonPropertyName("MaxOutsideTemperature"), Description("Max outside temperature")]
        public double MaxOutsideTemperature { get; set; }

        [JsonInclude, JsonPropertyName("OffOutsideTemperature"), Description("Off outside temperature")]
        public double OffOutsideTemperature { get; set; }

        public Emitter()
            : base()
        {

        }

        public Emitter(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Emitter(Emitter emitter)
            : base(emitter)
        {
            if (emitter != null)
            {
                Name = emitter.Name;
                Description = emitter.Description;
                RadiantProportion = Core.Query.Clone(emitter.RadiantProportion);
                ViewCoefficient = Core.Query.Clone(emitter.ViewCoefficient);
                MaxOutsideTemperature = emitter.MaxOutsideTemperature;
                OffOutsideTemperature = emitter.OffOutsideTemperature;
            }
        }
    }
}
