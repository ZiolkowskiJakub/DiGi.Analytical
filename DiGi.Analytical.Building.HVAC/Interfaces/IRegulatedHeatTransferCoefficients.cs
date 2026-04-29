using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.HVAC.Interfaces
{
    public interface IRegulatedHeatTransferCoefficients : IBuildingSerializableObject
    {
        RegulationAct? RegulationAct { get; }

        List<string> GetNames();

        bool TryGetValue(string name, out double value);
    }
}