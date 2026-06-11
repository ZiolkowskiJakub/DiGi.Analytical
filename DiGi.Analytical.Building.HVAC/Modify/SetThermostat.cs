using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        /// <summary>
        /// Sets the thermostat parameter for the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition instance to be modified.</param>
        /// <param name="thermostat">The thermostat object to assign to the internal condition.</param>
        /// <returns>True if the thermostat was successfully set; otherwise, false.</returns>
        public static bool SetThermostat(this InternalCondition? internalCondition, Thermostat? thermostat)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return internalCondition.SetValue(InternalConditionParameter.Thermostat, thermostat);
        }
    }
}