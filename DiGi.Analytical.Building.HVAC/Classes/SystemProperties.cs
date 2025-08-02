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

        [JsonInclude, JsonPropertyName("DHW"), Description("Domestic hot water [l/d/m2]")]
        public double DHW { get; set; }

        [JsonInclude, JsonPropertyName("OutsideAir"), Description("Outside air [l/s/p]")]
        public double OutsideAir { get; set; }

        [JsonInclude, JsonPropertyName("TargetRoomIlluminance"), Description("Target room illuminance [lx]")]
        public double TargetRoomIlluminance { get; set; }

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
                DHW = systemProperties.DHW;
                OutsideAir = systemProperties.OutsideAir;
                TargetRoomIlluminance = systemProperties.TargetRoomIlluminance;
            }
        }
    }
}
