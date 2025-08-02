using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        public static List<IProfile> Profiles(this IInternalCondition internalCondition)
        {
            if (internalCondition == null)
            {
                return null;
            }

            List<IProfile> result = new List<IProfile>();

            foreach(InternalGainProfileType internalGainProfileType in System.Enum.GetValues(typeof(InternalGainProfileType)))
            {
                IProfile profile = internalCondition.Profile(internalGainProfileType);
                if(profile != null)
                {
                    result.Add(profile);
                }
            }

            foreach (ThermostatProfileType thermostatProfileType in System.Enum.GetValues(typeof(ThermostatProfileType)))
            {
                IProfile profile = internalCondition.Profile(thermostatProfileType);
                if (profile != null)
                {
                    result.Add(profile);
                }
            }

            return result;
        }
    }
}