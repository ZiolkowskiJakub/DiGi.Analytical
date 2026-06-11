using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    /// <summary>
    /// Manages the collection and retrieval of regulated heat transfer coefficients associated with specific timestamps.
    /// </summary>
    public class RegulatedHeatTransferCoefficientsManager : SerializableObject, IHVACObject
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly SortedDictionary<DateTime, IRegulatedHeatTransferCoefficients> values = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficientsManager"/> class.
        /// </summary>
        public RegulatedHeatTransferCoefficientsManager()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficientsManager"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to populate the properties of the manager.</param>
        public RegulatedHeatTransferCoefficientsManager(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedHeatTransferCoefficientsManager"/> class by copying the specified instance.
        /// </summary>
        /// <param name="regulatedHeatTransferCoefficientsManager">The source <see cref="RegulatedHeatTransferCoefficientsManager"/> instance to copy from.</param>
        public RegulatedHeatTransferCoefficientsManager(RegulatedHeatTransferCoefficientsManager regulatedHeatTransferCoefficientsManager)
            : base(regulatedHeatTransferCoefficientsManager)
        {
            if (regulatedHeatTransferCoefficientsManager is not null)
            {
                foreach (IRegulatedHeatTransferCoefficients regulatedHeatTransferCoefficients in values.Values)
                {
                    Add(regulatedHeatTransferCoefficients);
                }
            }
        }

        /// <summary>
        /// Adds a regulated heat transfer coefficient to the manager.
        /// </summary>
        /// <param name="regulatedHeatTransferCoefficients">The regulated heat transfer coefficients to add.</param>
        /// <returns>True if the regulated heat transfer coefficients were successfully added; otherwise, false.</returns>
        public bool Add(IRegulatedHeatTransferCoefficients? regulatedHeatTransferCoefficients)
        {
            if (regulatedHeatTransferCoefficients?.RegulationAct is not RegulationAct regulationAct)
            {
                return false;
            }

            values[regulationAct.EffectiveDate] = regulatedHeatTransferCoefficients;
            return true;
        }

        /// <summary>
        /// Retrieves the regulated heat transfer coefficients applicable for the specified date and time.
        /// </summary>
        /// <param name="dateTime">The date and time used to determine the active regulated heat transfer coefficients.</param>
        /// <returns>The <see cref="IRegulatedHeatTransferCoefficients"/> corresponding to the provided date, or <c>null</c> if no applicable coefficients are found.</returns>
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

        /// <summary>
        /// Retrieves a list of regulated heat transfer coefficients filtered by the specified type.
        /// </summary>
        /// <typeparam name="TRegulatedHeatTransferCoefficients">The specific type of regulated heat transfer coefficients to retrieve, which must implement <see cref="IRegulatedHeatTransferCoefficients"/>.</typeparam>
        /// <returns>A list of all instances that match the specified type <typeparamref name="TRegulatedHeatTransferCoefficients"/>.</returns>
        public List<TRegulatedHeatTransferCoefficients> RegulatedHeatTransferCoefficients<TRegulatedHeatTransferCoefficients>() where TRegulatedHeatTransferCoefficients : IRegulatedHeatTransferCoefficients
        {
            List<TRegulatedHeatTransferCoefficients> result = [];
            foreach (IRegulatedHeatTransferCoefficients regulatedHeatTransferCoefficients in values.Values)
            {
                if (regulatedHeatTransferCoefficients is TRegulatedHeatTransferCoefficients regulatedHeatTransferCoefficients_Temp)
                {
                    result.Add(regulatedHeatTransferCoefficients_Temp);
                }
            }

            return result;
        }
    }
}