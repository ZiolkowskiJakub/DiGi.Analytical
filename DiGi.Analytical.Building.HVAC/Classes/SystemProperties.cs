using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class SystemProperties : ParametrizedObject, IHVACObject
    {
        [JsonInclude, JsonPropertyName("MetabolicRate"), Description("Metabolic rate [W/p]")]
        public double MetabolicRate { get; set; }

        [JsonInclude, JsonPropertyName("DomesticHotWater"), Description("Domestic hot water [l/d/m2]")]
        public double DomesticHotWater { get; set; }

        [JsonInclude, JsonPropertyName("OutsideAir"), Description("Outside air [l/s/p]")]
        public double OutsideAir { get; set; }

        [JsonInclude, JsonPropertyName("TargetIlluminance"), Description("Target illuminance [lx]")]
        public double TargetIlluminance { get; set; }

        public SystemProperties()
            : base()
        {

        }

        public SystemProperties(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public SystemProperties(SystemProperties systemProperties)
            : base(systemProperties)
        {
            if(systemProperties != null)
            {
                MetabolicRate = systemProperties.MetabolicRate;
                DomesticHotWater = systemProperties.DomesticHotWater;
                OutsideAir = systemProperties.OutsideAir;
                TargetIlluminance = systemProperties.TargetIlluminance;
            }
        }
    }
}
