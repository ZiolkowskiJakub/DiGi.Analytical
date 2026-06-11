using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    /// <summary>
    /// Specifies the type of the thermostat profile, defining whether it represents a temperature or humidity limit and its boundary direction.
    /// </summary>
    [Description("Thermostat profile type")]
    public enum ThermostatProfileType
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        [Description("Undefined")] Undefined,
        /// <summary>
        /// Represents the upper limit for the thermostat profile.
        /// </summary>
        [Description("Upper limit")] UpperLimit,
        /// <summary>
        /// Represents the lower limit of the thermostat profile.
        /// </summary>
        [Description("Lower limit")] LowerLimit,
        /// <summary>
        /// Represents the upper limit for humidity within the thermostat profile.
        /// </summary>
        [Description("Humidity upper limit")] HumidityUpperLimit,
        /// <summary>
        /// Represents the humidity lower limit thermostat profile type.
        /// </summary>
        [Description("Humidity lower limit")] HumidityLowerLimit,
    }
}