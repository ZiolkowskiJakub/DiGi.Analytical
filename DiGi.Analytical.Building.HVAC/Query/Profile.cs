using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        public static IProfile Profile(this InternalCondition internalCondition, ProfileType profileType)
        {
            if(internalCondition == null || profileType == ProfileType.Undefined)
            {
                return null;
            }

            return internalCondition.GetProfile(Core.Query.Description(profileType));
        }

        public static TProfile Profile<TProfile>(this InternalCondition internalCondition, ProfileType profileType) where TProfile : IProfile
        {
            IProfile profile = Profile(internalCondition, profileType);

            return profile is TProfile ? (TProfile)profile : default;
        }
    }
}