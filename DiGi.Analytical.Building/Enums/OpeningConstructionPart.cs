using System.ComponentModel;

namespace DiGi.Analytical.Building.Enums
{
    /// <summary>
    /// Specifies the various components that constitute an opening construction, such as panes and frames.
    /// </summary>
    [Description("Opening Construction Part")]
    public enum OpeningConstructionPart
    {
        /// <summary>
        /// The opening construction part is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Represents the pane part of an opening construction.
        /// </summary>
        [Description("Pane")] Pane,

        /// <summary>
        /// Represents the frame part of the opening construction.
        /// </summary>
        [Description("Frame")] Frame,
    }
}