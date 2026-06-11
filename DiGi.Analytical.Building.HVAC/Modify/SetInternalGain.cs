using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        /// <summary>
        /// Sets the internal gain for the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition instance to modify.</param>
        /// <param name="internalGain">The internal gain value to be set.</param>
        /// <returns>True if the internal gain was successfully set; otherwise, false.</returns>
        public static bool SetInternalGain(this InternalCondition? internalCondition, InternalGain? internalGain)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return internalCondition.SetValue(InternalConditionParameter.InternalGain, internalGain);
        }
    }
}