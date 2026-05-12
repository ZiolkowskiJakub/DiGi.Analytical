using DiGi.Analytical.Building.HVAC.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class RegulatedHeatTransferCoefficients_2014 : RegulatedHeatTransferCoefficients<ExternalPartitionType_2014>
    {
        public RegulatedHeatTransferCoefficients_2014(RegulationAct? regulationAct)
            : base(regulationAct)
        {
        }

        public RegulatedHeatTransferCoefficients_2014(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public RegulatedHeatTransferCoefficients_2014(RegulatedHeatTransferCoefficients_2014 regulatedHeatTransferCoefficients_2014)
            : base(regulatedHeatTransferCoefficients_2014)
        {
        }
    }
}