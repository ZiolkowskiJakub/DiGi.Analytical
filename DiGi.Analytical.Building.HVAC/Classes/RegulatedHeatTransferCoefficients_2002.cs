using DiGi.Analytical.Building.HVAC.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    /// <summary>
    /// Represents the regulated heat transfer coefficients according to the 2002 regulation standards for external partition types.
    /// </summary>
    public class RegulatedHeatTransferCoefficients_2002 : RegulatedHeatTransferCoefficients<ExternalPartitionType_2002>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients_2002"/> class.
        /// </summary>
        /// <param name="regulationAct">The regulation act used to initialize the heat transfer coefficients.</param>
        public RegulatedHeatTransferCoefficients_2002(RegulationAct? regulationAct)
            : base(regulationAct)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients_2002"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public RegulatedHeatTransferCoefficients_2002(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients_2002"/> class using another instance of the same type.
        /// </summary>
        /// <param name="regulatedHeatTransferCoefficients_2002">The source instance to copy from.</param>
        public RegulatedHeatTransferCoefficients_2002(RegulatedHeatTransferCoefficients_2002 regulatedHeatTransferCoefficients_2002)
            : base(regulatedHeatTransferCoefficients_2002)
        {
        }
    }
}