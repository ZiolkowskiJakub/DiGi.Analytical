using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        public static bool Assign(this BuildingModel buildingModel, ISpace space, IInternalCondition internalCondition, string id = null)
        {
            if (space == null || internalCondition == null)
            {
                return false;
            }

            List<IProfile> profiles = internalCondition.Profiles();

            if (profiles == null || profiles.Count == 0)
            {
                return false;
            }

            int max = -1;

            foreach (IProfile profile in profiles)
            {
                if (profile == null)
                {
                    continue;
                }

                if (max < profile.Count)
                {
                    max = profile.Count;
                }
            }

            if (max <= 0)
            {
                return false;
            }

            HourRange hourRange = new HourRange(0, max - 1);

            return buildingModel.Assign(space, internalCondition, hourRange, id);
        }
    }
}
