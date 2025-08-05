using DiGi.Analytical.Building.HVAC.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        public static Thermostat Thermostat(this IInternalCondition internalCondition)
        {
            if (internalCondition == null)
            {
                return null;
            }

            if (!internalCondition.TryGetValue(new EnumParameterDefinition(InternalConditionParameter.Thermostat), out Thermostat result, new GetValueSettings(true, false)))
            {
                return null;
            }

            return result;
        }
    }
}