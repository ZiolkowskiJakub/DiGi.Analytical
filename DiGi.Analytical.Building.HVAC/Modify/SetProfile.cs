using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        /// <summary>
        /// Sets a specific internal gain profile for the provided internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition instance to modify.</param>
        /// <param name="internalGainProfileType">The type of internal gain profile to be assigned.</param>
        /// <param name="profile">The profile implementation to assign to the specified internal gain profile type.</param>
        /// <returns>True if the profile was successfully set; otherwise, false.</returns>
        public static bool SetProfile(this InternalCondition? internalCondition, InternalGainProfileType internalGainProfileType, IProfile? profile)
        {
            if (internalCondition == null)
            {
                return false;
            }

            InternalGain? internalGain = internalCondition.InternalGain();
            if (internalGain == null)
            {
                if (profile == null)
                {
                    return false;
                }

                internalGain = new InternalGain();
            }

            internalGain[internalGainProfileType] = profile;

            return internalCondition.SetInternalGain(internalGain);
        }

        /// <summary>
        /// Sets the specified profile for a thermostat of the given profile type within the internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition instance to modify.</param>
        /// <param name="thermostatProfileType">The type of thermostat profile to set.</param>
        /// <param name="profile">The profile to assign to the specified thermostat profile type.</param>
        /// <returns>True if the profile was successfully set or updated; otherwise, false.</returns>
        public static bool SetProfile(this InternalCondition? internalCondition, ThermostatProfileType thermostatProfileType, IProfile? profile)
        {
            if (internalCondition == null)
            {
                return false;
            }

            Thermostat? thermostat = internalCondition.Thermostat();
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