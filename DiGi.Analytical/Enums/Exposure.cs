using System.ComponentModel;

namespace DiGi.Analytical.Enums
{
    /// <summary>
    /// Specifies the classification of exposure, such as whether it is internal or external.
    /// </summary>
    [Description("Exposure")]
    public enum Exposure
    {
        /// <summary>
        /// The exposure is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Represents external exposure.
        /// </summary>
        [Description("External")] External,

        /// <summary>
        /// Represents an internal exposure.
        /// </summary>
        [Description("Internal")] Internal,
    }
}