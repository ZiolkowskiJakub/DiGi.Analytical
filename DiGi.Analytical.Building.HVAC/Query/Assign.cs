using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        public static bool Assign(this BuildingModel buildingModel, IInternalCondition internalCondition, IProfile profile, ProfileType profileType)
        {
            if(buildingModel == null || profile == null || internalCondition == null || profileType == ProfileType.Undefined || profileType == ProfileType.Other)
            {
                return false;
            }

            return buildingModel.Assign(internalCondition, profile, Core.Query.Description(profileType));
        }
    }
}