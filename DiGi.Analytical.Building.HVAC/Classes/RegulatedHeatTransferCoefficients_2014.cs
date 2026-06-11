using DiGi.Analytical.Building.HVAC.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    /// <summary>
    /// Represents the regulated heat transfer coefficients according to the 2014 regulations for external partition types.
    /// </summary>
    public class RegulatedHeatTransferCoefficients_2014 : RegulatedHeatTransferCoefficients<ExternalPartitionType_2014>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients_2014"/> class using the specified regulation act.
        /// </summary>
        /// <param name="regulationAct">The regulation act used to determine the heat transfer coefficients. This value can be null.</param>
        public RegulatedHeatTransferCoefficients_2014(RegulationAct? regulationAct)
            : base(regulationAct)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients_2014"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public RegulatedHeatTransferCoefficients_2014(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients_2014"/> class using an existing instance of the same type.
        /// </summary>
        /// <param name="regulatedHeatTransferCoefficients_2014">The source <see cref="RegulatedHeatTransferCoefficients_2014"/> instance to copy from.</param>
        public RegulatedHeatTransferCoefficients_2014(RegulatedHeatTransferCoefficients_2014 regulatedHeatTransferCoefficients_2014)
            : base(regulatedHeatTransferCoefficients_2014)
        {
        }
    }
}