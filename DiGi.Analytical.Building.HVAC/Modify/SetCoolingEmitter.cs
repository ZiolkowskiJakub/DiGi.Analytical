using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        /// <summary>
        /// Sets the cooling emitter for the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition instance to modify.</param>
        /// <param name="coolingEmitter">The cooling emitter to assign to the internal condition.</param>
        /// <returns>True if the cooling emitter was successfully set; otherwise, false.</returns>
        public static bool SetHeatingEmitter(this InternalCondition? internalCondition, CoolingEmitter? coolingEmitter)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return internalCondition.SetValue(InternalConditionParameter.CoolingEmitter, coolingEmitter);
        }
    }
}