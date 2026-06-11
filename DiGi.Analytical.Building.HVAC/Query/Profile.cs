using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the internal gain profile for the specified profile type from the given internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition instance to query.</param>
        /// <param name="internalGainProfileType">The specific internal gain profile type to retrieve.</param>
        /// <returns>The matching <see cref="IProfile"/> if found; otherwise, <c>null</c>.</returns>
        public static IProfile? Profile(this IInternalCondition? internalCondition, InternalGainProfileType internalGainProfileType)
        {
            if (internalCondition == null || internalGainProfileType == InternalGainProfileType.Undefined)
            {
                return null;
            }

            return internalCondition.InternalGain()?[internalGainProfileType];
        }

        /// <summary>
        /// Retrieves the specified thermostat profile for the given internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition instance to query.</param>
        /// <param name="thermostatProfileType">The specific type of thermostat profile to retrieve.</param>
        /// <returns>The matching <see cref="IProfile"/> if found; otherwise, <see langword="null"/>.</returns>
        public static IProfile? Profile(this IInternalCondition? internalCondition, ThermostatProfileType thermostatProfileType)
        {
            if (internalCondition == null || thermostatProfileType == ThermostatProfileType.Undefined)
            {
                return null;
            }

            return internalCondition.Thermostat()?[thermostatProfileType];
        }
    }
}