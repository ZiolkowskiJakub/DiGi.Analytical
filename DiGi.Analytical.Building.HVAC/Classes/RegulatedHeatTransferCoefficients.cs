using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Core.Classes;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    /// <summary>
    /// Provides an abstract base implementation for regulated heat transfer coefficients, associating specific regulatory categories with their corresponding numerical values.
    /// </summary>
    /// <typeparam name="TEnum">The enumeration type used to define the keys for the heat transfer coefficient values.</typeparam>
    public abstract class RegulatedHeatTransferCoefficients<TEnum> : SerializableObject, IRegulatedHeatTransferCoefficients where TEnum : Enum
    {
        [JsonInclude, JsonPropertyName(nameof(RegulationAct))]
        private readonly RegulationAct? regulationAct;

        [JsonInclude, JsonPropertyName("Values")]
        private readonly Dictionary<TEnum, double> values = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients{TEnum}"/> class with the specified regulation act.
        /// </summary>
        /// <param name="regulationAct">The regulation act associated with the heat transfer coefficients, or <see langword="null"/> if not specified.</param>
        public RegulatedHeatTransferCoefficients(RegulationAct? regulationAct)
            : base()
        {
            this.regulationAct = regulationAct;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients{TEnum}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the serialized data for initialization.</param>
        public RegulatedHeatTransferCoefficients(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficients{TEnum}"/> class by copying the values from an existing instance.
        /// </summary>
        /// <param name="regulatedHeatTransferCoefficients">The source instance to copy heat transfer coefficients and regulation act from.</param>
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

        /// <summary>
        /// Gets the regulation act associated with the regulated heat transfer coefficients.
        /// </summary>
        [JsonIgnore]
        public RegulationAct? RegulationAct
        {
            get
            {
                return regulationAct;
            }
        }

        /// <summary>
        /// Gets or sets the heat transfer coefficient associated with the specified enumeration member.
        /// </summary>
        /// <param name="enum">The enumeration member used to access the heat transfer coefficient.</param>
        /// <returns>The heat transfer coefficient value associated with the specified enumeration member.</returns>
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

        /// <summary>
        /// Retrieves the list of enumeration values used as keys for the heat transfer coefficients.
        /// </summary>
        /// <returns>A <see cref="System.Collections.Generic.List{TEnum}"/> containing all the enumeration values currently defined in the coefficients collection.</returns>
        public List<TEnum> GetEnums()
        {
            return [.. values.Keys];
        }

        /// <summary>
        /// Retrieves a list of names or descriptions for the regulated heat transfer coefficients.
        /// </summary>
        /// <returns>A list of strings representing the names of the coefficients.</returns>
        public List<string> GetNames()
        {
            List<string> result = [];

            foreach (TEnum @enum in values.Keys)
            {
                result.Add(Core.Query.Description(@enum) ?? @enum.ToString());
            }

            return result;
        }

        /// <summary>
        /// Sets the heat transfer coefficient value for the specified enumeration member.
        /// </summary>
        /// <param name="enum">The enumeration member identifying the coefficient to set.</param>
        /// <param name="value">The numeric value to assign to the coefficient.</param>
        /// <returns>True if the value was successfully set; false if the provided value is <see cref="System.Double.NaN"/>.</returns>
        public bool SetValue(TEnum @enum, double value)
        {
            if (double.IsNaN(value))
            {
                return false;
            }

            values[@enum] = value;
            return true;
        }

        /// <summary>
        /// Attempts to retrieve the heat transfer coefficient value associated with the specified enumeration member.
        /// </summary>
        /// <param name="enum">The enumeration member used as the key for retrieval.</param>
        /// <param name="value">When this method returns, contains the retrieved value if successful; otherwise, <see cref="double.NaN"/>.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue(TEnum @enum, out double value)
        {
            if (!values.TryGetValue(@enum, out value))
            {
                value = double.NaN;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Attempts to retrieve the heat transfer coefficient value associated with the specified name.
        /// </summary>
        /// <param name="name">The name of the coefficient to retrieve, matching either the enum description or its string representation.</param>
        /// <param name="value">When this method returns, contains the retrieved value if successful; otherwise, <see cref="double.NaN"/>.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
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