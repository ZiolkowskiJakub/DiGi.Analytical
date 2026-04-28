using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class RegulatedHeatTransferCoefficientsManager : SerializableObject, IHVACObject
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly SortedDictionary<DateTime, IRegulatedHeatTransferCoefficients> values = [];

        public RegulatedHeatTransferCoefficientsManager()
            : base()
        {

        }

        public RegulatedHeatTransferCoefficientsManager(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public RegulatedHeatTransferCoefficientsManager(RegulatedHeatTransferCoefficientsManager regulatedHeatTransferCoefficientsManager)
            : base(regulatedHeatTransferCoefficientsManager)
        {
            if(regulatedHeatTransferCoefficientsManager is not null)
            {
                foreach(IRegulatedHeatTransferCoefficients regulatedHeatTransferCoefficients in values.Values)
                {
                    Add(regulatedHeatTransferCoefficients);
                }
            }
        }

        public bool Add(IRegulatedHeatTransferCoefficients? regulatedHeatTransferCoefficients)
        {
            if(regulatedHeatTransferCoefficients?.RegulationAct is not RegulationAct regulationAct)
            {
                return false;
            }

            values[regulationAct.EffectiveDate] = regulatedHeatTransferCoefficients;
            return true;
        }

        public IRegulatedHeatTransferCoefficients? GetRegulatedHeatTransferCoefficients(DateTime dateTime)
        {
            if (values is null || values.Count == 0)
            {
                return null;
            }

            if (dateTime < values.Keys.First())
            {
                return null;
            }

            if (values.Count == 1)
            {
                return values.Values.First();
            }

            if (dateTime >= values.Keys.Last())
            {
                return values.Values.Last();
            }

            List<DateTime> dateTimes = [.. values.Keys];

            for (int i = 1; i < dateTimes.Count; i++)
            {
                if (dateTimes[i] > dateTime)
                {
                    return values[dateTimes[i - 1]];
                }
            }

            return null;
        }

        public List<TRegulatedHeatTransferCoefficients> RegulatedHeatTransferCoefficients<TRegulatedHeatTransferCoefficients>() where TRegulatedHeatTransferCoefficients : IRegulatedHeatTransferCoefficients
        {
            List<TRegulatedHeatTransferCoefficients> result = [];
            foreach (IRegulatedHeatTransferCoefficients regulatedHeatTransferCoefficients in values.Values)
            {
                if(regulatedHeatTransferCoefficients is TRegulatedHeatTransferCoefficients regulatedHeatTransferCoefficients_Temp)
                {
                    result.Add(regulatedHeatTransferCoefficients_Temp);
                }
            }

            return result;
        }
    }
}
