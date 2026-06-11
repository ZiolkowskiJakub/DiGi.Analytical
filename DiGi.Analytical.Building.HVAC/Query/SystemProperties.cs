using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the system properties associated with the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition instance to query for system properties.</param>
        /// <returns>The <see cref="SystemProperties"/> if found; otherwise, <c>null</c>.</returns>
        public static SystemProperties? SystemProperties(this IInternalCondition? internalCondition)
        {
            if (internalCondition == null)
            {
                return null;
            }

            if (!internalCondition.TryGetValue(new EnumParameterDefinition(InternalConditionParameter.SystemProperties), out SystemProperties? result, new GetValueSettings(true, false)))
            {
                return null;
            }

            return result;
        }
    }
}