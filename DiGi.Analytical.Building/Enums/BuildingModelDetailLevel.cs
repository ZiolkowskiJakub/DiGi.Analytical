using System.ComponentModel;

namespace DiGi.Analytical.Building.Enums
{
    [Description("BuildingModel detail level")]
    public enum BuildingModelDetailLevel
    {
        /// <summary>
        /// Each component (wall, roof, floor, window) becomes a separate selectable node.
        /// </summary>
        [Description("Component")] Component,

        /// <summary>
        /// All components are merged into a single node per building, making the building selectable as a whole.
        /// </summary>
        [Description("Envelope")] Envelope,
    }
}