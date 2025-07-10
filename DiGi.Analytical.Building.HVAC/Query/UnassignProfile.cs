using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        public static bool UnassignProfile(this BuildingModel buildingModel, IInternalCondition internalCondition, ProfileType profileType)
        {
            if(buildingModel == null || internalCondition == null || profileType == ProfileType.Undefined || profileType == ProfileType.Other)
            {
                return default;
            }

            return buildingModel.UnassignProfile(internalCondition, Core.Query.Description(profileType));
        }
    }
}