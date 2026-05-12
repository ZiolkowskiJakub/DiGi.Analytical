using DiGi.Analytical.Building.HVAC.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class RegulatedHeatTransferCoefficients_2002 : RegulatedHeatTransferCoefficients<ExternalPartitionType_2002>
    {
        public RegulatedHeatTransferCoefficients_2002(RegulationAct? regulationAct)
            : base(regulationAct)
        {
        }

        public RegulatedHeatTransferCoefficients_2002(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public RegulatedHeatTransferCoefficients_2002(RegulatedHeatTransferCoefficients_2002 regulatedHeatTransferCoefficients_2002)
            : base(regulatedHeatTransferCoefficients_2002)
        {
        }
    }
}