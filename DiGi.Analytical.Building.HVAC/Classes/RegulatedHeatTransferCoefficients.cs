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
            : base(jsonObject)
        {
        }

        public RegulatedHeatTransferCoefficients(RegulatedHeatTransferCoefficients<TEnum> regulatedHeatTransferCoefficients)
            : base(regulatedHeatTransferCoefficients)
        {
            if (regulatedHeatTransferCoefficients is not null)
            {
                regulationAct = Core.Query.Clone(regulatedHeatTransferCoefficients.regulationAct);
                foreach (KeyValuePair<TEnum, double> keyValuePair in regulatedHeatTransferCoefficients.values)
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

        public List<TEnum> GetEnums()
        {
            return [.. values.Keys];
        }

        public List<string> GetNames()
        {
            List<string> result = [];

            foreach (TEnum @enum in values.Keys)
            {
                result.Add(Core.Query.Description(@enum) ?? @enum.ToString());
            }

            return result;
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
            if (!values.TryGetValue(@enum, out value))
            {
                value = double.NaN;
                return false;
            }

            return true;
        }

        public bool TryGetValue(string name, out double value)
        {
            value = double.NaN;

            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            foreach (KeyValuePair<TEnum, double> keyValuePair in values)
            {
                if (name == (Core.Query.Description(keyValuePair.Key) ?? keyValuePair.Key.ToString()))
                {
                    value = keyValuePair.Value;
                    return true;
                }
            }

            return false;
        }
    }
}