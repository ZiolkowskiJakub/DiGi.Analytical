using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        public static bool SetProfile(this InternalCondition internalCondition, InternalGainProfileType internalGainProfileType, IProfile profile)
        {
            if (internalCondition == null)
            {
                return false;
            }

            InternalGain internalGain = internalCondition.InternalGain();
            if(internalGain == null)
            {
                if(profile == null)
                {
                    return false;
                }

                internalGain = new InternalGain();
            }

            internalGain[internalGainProfileType] = profile;

            return internalCondition.SetInternalGain(internalGain);
        }

        public static bool SetProfile(this InternalCondition internalCondition, ThermostatProfileType thermostatProfileType, IProfile profile)
        {
            if (internalCondition == null)
            {
                return false;
            }

            Thermostat thermostat = internalCondition.Thermostat();
            if (thermostat == null)
            {
                if (profile == null)
                {
                    return false;
                }

                thermostat = new Thermostat();
            }

            thermostat[thermostatProfileType] = profile;

            return internalCondition.SetThermostat(thermostat);
        }
    }
}