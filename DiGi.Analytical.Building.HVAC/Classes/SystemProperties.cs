using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    /// <summary>
    /// Represents the configuration properties for an HVAC system, encompassing parameters such as metabolic rate, domestic hot water usage, outside air requirements, and target illuminance.
    /// </summary>
    public class SystemProperties : ParametrizedObject, IHVACObject
    {
        /// <summary>
        /// Gets or sets the metabolic rate [W/p].
        /// </summary>
        [JsonInclude, JsonPropertyName("MetabolicRate"), Description("Metabolic rate [W/p]")]
        public double MetabolicRate { get; set; }

        /// <summary>
        /// Gets or sets the domestic hot water usage in liters per day per square meter [l/d/m2].
        /// </summary>
        [JsonInclude, JsonPropertyName("DomesticHotWater"), Description("Domestic hot water [l/d/m2]")]
        public double DomesticHotWater { get; set; }

        /// <summary>
        /// Gets or sets the outside air flow rate in liters per second per person [l/s/p].
        /// </summary>
        [JsonInclude, JsonPropertyName("OutsideAir"), Description("Outside air [l/s/p]")]
        public double OutsideAir { get; set; }

        /// <summary>
        /// Gets or sets the target illuminance [lx].
        /// </summary>
        [JsonInclude, JsonPropertyName("TargetIlluminance"), Description("Target illuminance [lx]")]
        public double TargetIlluminance { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemProperties"/> class.
        /// </summary>
        public SystemProperties()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemProperties"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the system properties data, or <see langword="null"/>.</param>
        public SystemProperties(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemProperties"/> class using the properties of another <see cref="SystemProperties"/> instance.
        /// </summary>
        /// <param name="systemProperties">The source <see cref="SystemProperties"/> instance to copy values from. If null, the object is initialized with default values.</param>
        public SystemProperties(SystemProperties? systemProperties)
            : base(systemProperties)
        {
            if (systemProperties != null)
            {
                MetabolicRate = systemProperties.MetabolicRate;
                DomesticHotWater = systemProperties.DomesticHotWater;
                OutsideAir = systemProperties.OutsideAir;
                TargetIlluminance = systemProperties.TargetIlluminance;
            }
        }
    }
}