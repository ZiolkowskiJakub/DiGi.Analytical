using DiGi.Analytical.Building.HVAC.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    /// <summary>
    /// Provides the regulated heat transfer coefficients based on the 2009 regulations for external partition types.
    /// </summary>
    public class RegulatedHeatTransferCoefficients_2009 : RegulatedHeatTransferCoefficients<ExternalPartitionType_2009>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients_2009"/> class.
        /// </summary>
        /// <param name="regulationAct">The regulation act used to determine the heat transfer coefficients.</param>
        public RegulatedHeatTransferCoefficients_2009(RegulationAct? regulationAct)
            : base(regulationAct)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients_2009"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public RegulatedHeatTransferCoefficients_2009(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients_2009"/> class using another instance of the same type.
        /// </summary>
        /// <param name="regulatedHeatTransferCoefficients_2009">The source instance to copy from.</param>
        public RegulatedHeatTransferCoefficients_2009(RegulatedHeatTransferCoefficients_2009 regulatedHeatTransferCoefficients_2009)
            : base(regulatedHeatTransferCoefficients_2009)
        {
        }
    }
}