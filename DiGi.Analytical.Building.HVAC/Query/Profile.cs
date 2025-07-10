using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        public static TProfie Profile<TProfie>(this BuildingModel buildingModel, IInternalCondition internalCondition, ProfileType profileType) where TProfie : IProfile
        {
            if(buildingModel == null || internalCondition == null || profileType == ProfileType.Undefined || profileType == ProfileType.Other)
            {
                return default;
            }

            return buildingModel.GetProfile<TProfie>(internalCondition, Core.Query.Description(profileType));
        }
    }
}