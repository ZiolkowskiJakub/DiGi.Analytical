using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        public static bool SetThermostat(this InternalCondition internalCondition, Thermostat thermostat)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return internalCondition.SetValue(SpaceParameter.Thermostat, thermostat);
        }
    }
}