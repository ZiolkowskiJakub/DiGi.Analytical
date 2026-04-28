using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC.Interfaces
{
    public interface IRegulatedHeatTransferCoefficients : IBuildingObject
    {
        RegulationAct? RegulationAct { get; }
    }
}