using System.ComponentModel;

namespace DiGi.Analytical.Building.Enums
{
    /// <summary>
    /// Specifies the relative position of a structural element within a building.
    /// </summary>
    [Description("Structure Position")]
    public enum StructurePosition
    {
        /// <summary>Undefined</summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Indicates that the structure position is at the center.
        /// </summary>
        [Description("Center")] Center,

        /// <summary>
        /// Represents the external structure position.
        /// </summary>
        [Description("External")] External,

        /// <summary>
        /// Represents the internal structure position.
        /// </summary>
        [Description("Internal")] Internal,
    }
}