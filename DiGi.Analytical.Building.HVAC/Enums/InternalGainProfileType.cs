using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    /// <summary>
    /// Specifies the type of internal gain profile used in HVAC analytical calculations.
    /// </summary>
    [Description("Internal gain profile type")]
    public enum InternalGainProfileType
    {
        /// <summary>
        /// Undefined internal gain profile type.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Represents the internal gain profile type for infiltration.
        /// </summary>
        [Description("Infiltration")] Infiltration,

        /// <summary>
        /// Represents an internal gain profile type associated with ventilation.
        /// </summary>
        [Description("Ventilation")] Ventilation,

        /// <summary>
        /// Represents the internal heat gain profile associated with lighting.
        /// </summary>
        [Description("Lighting gain")] LightingGain,

        /// <summary>
        /// Represents the internal gain profile type for occupancy sensible heat gain.
        /// </summary>
        [Description("Occupancy sensible gain")] OccupancySensibleGain,

        /// <summary>Represents the internal gain profile type for occupancy latent gain.</summary>
        [Description("Occupancy latent gain")] OccupancyLatentGain,

        /// <summary>
        /// Represents an internal gain profile type for equipment sensible gain.
        /// </summary>
        [Description("Equipment sensible gain")] EquipmentSensibleGain,

        /// <summary>
        /// Represents the internal gain profile type for equipment latent gain.
        /// </summary>
        [Description("Equipment latent gain")] EquipmentLatentGain,

        /// <summary>
        /// Represents an internal gain profile type associated with pollutant generation.
        /// </summary>
        [Description("Pollutant generation")] PollutantGeneration,
    }
}