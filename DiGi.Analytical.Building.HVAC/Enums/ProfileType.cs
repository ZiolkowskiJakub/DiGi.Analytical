using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    [Description("Profile type")]
    public enum ProfileType
    {
        [Description("Undefined")] Undefined,
        [Description("Other")] Other,
        [Description("Infiltration")] Infiltration,
        [Description("Ventilation")] Ventilation,
        [Description("Lighting gain")] LightingGain,
        [Description("Occupancy sensible gain")] OccupancySensibleGain,
        [Description("Occupancy latent gain")] OccupancyLatentGain,
        [Description("Equipment sensible gain")] EquipmentSensibleGain,
        [Description("Equipment latent gain")] EquipmentLatentGain,
        [Description("Pollutant generation")] PollutantGeneration,
        [Description("Thermostat upper limit")] ThermostatUpperLimit,
        [Description("Thermostat lower limit")] ThermostatLowerLimit,
        [Description("Thermostat humidity upper limit")] ThermostatHumidityUpperLimit,
        [Description("Thermostat humidity lower limit")] ThermostatHumidityLowerLimit,
    }
}
