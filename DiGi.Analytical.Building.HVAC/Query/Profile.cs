using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        public static IProfile Profile(this IInternalCondition internalCondition, InternalGainProfileType internalGainProfileType)
        {
            if (internalCondition == null || internalGainProfileType == InternalGainProfileType.Undefined)
            {
                return null;
            }

            return internalCondition.InternalGain()?[internalGainProfileType];
        }

        public static IProfile Profile(this IInternalCondition internalCondition, ThermostatProfileType thermostatProfileType)
        {
            if (internalCondition == null || thermostatProfileType == ThermostatProfileType.Undefined)
            {
                return null;
            }

            return internalCondition.Thermostat()?[thermostatProfileType];
        }
    }
}