using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the internal gain from the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition to retrieve the internal gain from.</param>
        /// <returns>The <see cref="InternalGain"/> if successfully retrieved; otherwise, <see langword="null"/>.</returns>
        public static InternalGain? InternalGain(this IInternalCondition? internalCondition)
        {
            if (internalCondition == null)
            {
                return null;
            }

            if (!internalCondition.TryGetValue(new EnumParameterDefinition(InternalConditionParameter.InternalGain), out InternalGain? result, new GetValueSettings(true, false)))
            {
                return null;
            }

            return result;
        }
    }
}