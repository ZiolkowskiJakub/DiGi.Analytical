using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        /// <summary>
        /// Sets the system properties for the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition instance to modify.</param>
        /// <param name="systemProperties">The system properties to be assigned.</param>
        /// <returns><see langword="true"/> if the system properties were successfully set; otherwise, <see langword="false"/>.</returns>
        public static bool SetSystemProperties(this InternalCondition? internalCondition, SystemProperties? systemProperties)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return internalCondition.SetValue(InternalConditionParameter.SystemProperties, systemProperties);
        }
    }
}