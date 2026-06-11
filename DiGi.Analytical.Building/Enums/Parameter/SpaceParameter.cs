using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;

namespace DiGi.Analytical.Building.Enums
{
    /// <summary>
    /// Defines the set of parameters associated with a space in the analytical building model.
    /// </summary>
    [AssociatedTypes(typeof(ISpace)), Description("Space parameter")]
    public enum SpaceParameter
    {
        /// <summary>
        /// Represents the calculated area of the space in square meters (m2).
        /// </summary>
        [ParameterProperties("d548c4b7-73d5-4a7c-8ba4-2b4a44da0bcf", "Calculated area", "Calculated area [m2]"), DoubleParameterValue(0.0)] CalculatedArea,
        /// <summary>
        /// Represents the calculated volume of a space, typically measured in cubic meters (m3).
        /// </summary>
        [ParameterProperties("dd3623dd-2257-4da7-beda-e463cf4f6b78", "Calculated volume", "Calculated volume [m3]"), DoubleParameterValue(0.0)] CalculatedVolume,
    }
}