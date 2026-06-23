using System.ComponentModel;

namespace DiGi.Analytical.Building.HVAC.Enums
{
    /// <summary>
    /// Specifies the type of external partition used in HVAC building analysis according to 2014 standards.
    /// </summary>
    public enum ExternalPartitionType_2014
    {
        /// <summary>Represents an external wall partition.</summary>
        [Description("Wall")] Wall,

        /// <summary>Represents a roof over heated rooms.</summary>
        [Description("Roof over heated rooms")] Roof,

        /// <summary>
        /// Represents a floor partition located over unheated spaces.
        /// </summary>
        [Description("Floor over unheated spaces")] Floor_OverUnheatedSpaces,

        /// <summary>
        /// Represents a floor partition located on the ground.
        /// </summary>
        [Description("Floor on ground")] Floor,

        /// <summary>
        /// Represents a window or balcony door as an external partition type.
        /// </summary>
        [Description("Window or balcony door")] Window,

        /// <summary>
        /// Represents a roof window or skylight external partition type.
        /// </summary>
        [Description("Roof window or skylight")] Window_Skylight,

        /// <summary>
        /// Specifies that the external partition is a door.
        /// </summary>
        [Description("Door")] Door,
    }
}