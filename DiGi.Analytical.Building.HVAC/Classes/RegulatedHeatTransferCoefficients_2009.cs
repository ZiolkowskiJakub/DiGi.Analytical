using DiGi.Analytical.Building.HVAC.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class RegulatedHeatTransferCoefficients_2009 : RegulatedHeatTransferCoefficients<ExternalPartitionType_2009>
    {
        public RegulatedHeatTransferCoefficients_2009(RegulationAct? regulationAct)
            : base(regulationAct)
        {
        }

        public RegulatedHeatTransferCoefficients_2009(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public RegulatedHeatTransferCoefficients_2009(RegulatedHeatTransferCoefficients_2009 regulatedHeatTransferCoefficients_2009)
            : base(regulatedHeatTransferCoefficients_2009)
        {
        }
    }
}