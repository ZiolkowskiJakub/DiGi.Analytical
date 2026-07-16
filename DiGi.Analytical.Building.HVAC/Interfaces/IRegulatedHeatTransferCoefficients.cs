using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.HVAC.Interfaces
{
    /// <summary>
    /// Interface for regulated heat transfer coefficients defined by building regulations.
    /// </summary>
    public interface IRegulatedHeatTransferCoefficients : IBuildingSerializableObject
    {
        /// <summary>
        /// Gets the regulation act that defines these heat transfer coefficients.
        /// </summary>
        RegulationAct? RegulationAct { get; }

        /// <summary>
        /// Gets the list of all coefficient names defined in this regulation.
        /// </summary>
        /// <returns>A list of coefficient names.</returns>
        List<string> GetNames();

        /// <summary>
        /// Attempts to retrieve the heat transfer coefficient value for the specified name.
        /// </summary>
        /// <param name="name">The name of the coefficient to retrieve.</param>
        /// <param name="value">When this method returns, contains the coefficient value if found; otherwise, zero.</param>
        /// <returns><see langword="true"/> if the coefficient was found; otherwise, <see langword="false"/>.</returns>
        bool TryGetValue(string name, out double value);
    }
}