using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Core.Classes;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public abstract class RegulatedHeatTransferCoefficients<TEnum> : SerializableObject, IRegulatedHeatTransferCoefficients where TEnum : Enum
    {
        [JsonInclude, JsonPropertyName(nameof(RegulationAct))]
        private readonly RegulationAct? regulationAct;

        [JsonInclude, JsonPropertyName("Values")]
        private readonly Dictionary<TEnum, double> values = [];

        public RegulatedHeatTransferCoefficients(RegulationAct? regulationAct)
            : base()
        {
            this.regulationAct = regulationAct;
        }

        public RegulatedHeatTransferCoefficients(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public RegulatedHeatTransferCoefficients(RegulatedHeatTransferCoefficients<TEnum> regulatedHeatTransferCoefficients)
            : base(regulatedHeatTransferCoefficients)
        {
            if(regulatedHeatTransferCoefficients is not null)
            {
                regulationAct = Core.Query.Clone(regulatedHeatTransferCoefficients.regulationAct);
                foreach(KeyValuePair<TEnum, double> keyValuePair in regulatedHeatTransferCoefficients.values)
                {
                    SetValue(keyValuePair.Key, keyValuePair.Value);
                }
            }
        }

        [JsonIgnore]
        public RegulationAct? RegulationAct
        {
            get
            {
                return regulationAct;
            }
        }

        public double this[TEnum @enum]
        {
            get
            {
                return values[@enum];
            }

            set
            {
                values[@enum] = value;
            }
        }

        public bool SetValue(TEnum @enum, double value)
        {
            if (double.IsNaN(value))
            {
                return false;
            }

            values[@enum] = value;
            return true;
        }

        public bool TryGetValue(TEnum @enum, out double value)
        {
            if(!values.TryGetValue(@enum, out value))
            {
                value = double.NaN;
                return false;
            }

            return true;
        }
    }
}
