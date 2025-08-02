using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    [Description("Thermostat profile type")]
    public enum ThermostatProfileType
    {
        [Description("Undefined")] Undefined,
        [Description("Upper limit")] UpperLimit,
        [Description("Lower limit")] LowerLimit,
        [Description("Humidity upper limit")] HumidityUpperLimit,
        [Description("Humidity lower limit")] HumidityLowerLimit,
    }
}
