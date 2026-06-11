using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the heating emitter associated with the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition from which to retrieve the heating emitter.</param>
        /// <returns>The <see cref="HeatingEmitter"/> if found; otherwise, <c>null</c>.</returns>
        public static HeatingEmitter? HeatingEmitter(this IInternalCondition? internalCondition)
        {
            if (internalCondition == null)
            {
                return null;
            }

            if (!internalCondition.TryGetValue(new EnumParameterDefinition(InternalConditionParameter.HeatingEmitter), out HeatingEmitter? result, new GetValueSettings(true, false)))
            {
                return null;
            }

            return result;
        }
    }
}