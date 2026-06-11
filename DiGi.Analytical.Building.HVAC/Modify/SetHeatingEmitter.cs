using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        /// <summary>
        /// Sets the heating emitter for the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition to modify.</param>
        /// <param name="heatingEmitter">The heating emitter to assign.</param>
        /// <returns><see langword="true"/> if the value was successfully set; otherwise, <see langword="false"/>.</returns>
        public static bool SetHeatingEmitter(this InternalCondition? internalCondition, HeatingEmitter? heatingEmitter)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return internalCondition.SetValue(InternalConditionParameter.HeatingEmitter, heatingEmitter);
        }
    }
}