using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Core;
using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Create
    {
        public static Profile Profile(this IEnumerable<double> values, ProfileType profileType)
        {
            if(values == null || profileType == ProfileType.Undefined)
            {
                return null;
            }

            return new Profile(profileType.Description(), values);
        }
    }
}