using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        public static bool SetSystemProperties(this InternalCondition internalCondition, SystemProperties systemProperties)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return internalCondition.SetValue(SpaceParameter.SystemProperties, systemProperties);
        }
    }
}