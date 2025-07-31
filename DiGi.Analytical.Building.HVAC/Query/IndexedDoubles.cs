using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        public static IndexedDoubles IndexedDoubles(this BuildingModel buildingModel, ISpace space, Range<int> range, ProfileType profileType, string id = null)
        {
            if(buildingModel == null || space == null || range == null || profileType == ProfileType.Undefined)
            {
                return null;
            }

            return Building.Query.IndexedDoubles(buildingModel, space, range, profileType.Description(), id);
        }

        public static IndexedDoubles IndexedDoubles(this BuildingModel buildingModel, ISpace space, int start, int end, ProfileType profileType, string id = null)
        {
            if (buildingModel == null || space == null || profileType == ProfileType.Undefined)
            {
                return null;
            }

            return Building.Query.IndexedDoubles(buildingModel, space, start, end, profileType.Description(), id);
        }
    }
}