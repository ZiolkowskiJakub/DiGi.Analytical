using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Modify
    {
        /// <summary>
        /// Assigns a specified internal condition to a space within the building model.
        /// </summary>
        /// <param name="buildingModel">The <see cref="BuildingModel"/> instance that manages the assignment.</param>
        /// <param name="space">The <see cref="ISpace"/> to which the internal condition is assigned.</param>
        /// <param name="internalCondition">The <see cref="IInternalCondition"/> to be applied to the space.</param>
        /// <param name="id">An optional unique identifier for the assignment.</param>
        /// <returns>True if the internal condition was successfully assigned; otherwise, false.</returns>
        public static bool Assign(this BuildingModel? buildingModel, ISpace? space, IInternalCondition? internalCondition, string? id = null)
        {
            if (buildingModel is null || space is null || internalCondition is null)
            {
                return false;
            }

            List<IProfile>? profiles = internalCondition.Profiles();

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

            HourRange hourRange = new(0, max - 1);

            return buildingModel.Assign(space, internalCondition, hourRange, id);
        }
    }
}