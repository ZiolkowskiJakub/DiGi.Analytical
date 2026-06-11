using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the thermostat associated with the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition to query for the thermostat parameter.</param>
        /// <returns>The <see cref="Thermostat"/> instance if it exists; otherwise, <c>null</c>.</returns>
        public static Thermostat? Thermostat(this IInternalCondition? internalCondition)
        {
            if (internalCondition == null)
            {
                return null;
            }

            if (!internalCondition.TryGetValue(new EnumParameterDefinition(InternalConditionParameter.Thermostat), out Thermostat? result, new GetValueSettings(true, false)))
            {
                return null;
            }

            return result;
        }
    }
}