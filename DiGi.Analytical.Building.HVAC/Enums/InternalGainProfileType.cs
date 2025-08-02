using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    [Description("Internal gain profile type")]
    public enum InternalGainProfileType
    {
        [Description("Undefined")] Undefined,
        [Description("Infiltration")] Infiltration,
        [Description("Ventilation")] Ventilation,
        [Description("Lighting gain")] LightingGain,
        [Description("Occupancy sensible gain")] OccupancySensibleGain,
        [Description("Occupancy latent gain")] OccupancyLatentGain,
        [Description("Equipment sensible gain")] EquipmentSensibleGain,
        [Description("Equipment latent gain")] EquipmentLatentGain,
        [Description("Pollutant generation")] PollutantGeneration,
    }
}
