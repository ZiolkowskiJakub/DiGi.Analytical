using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        public static IndexedDoubles IndexedDoubles(this BuildingModel buildingModel, ISpace space, Range<int> range, System.Enum @enum, string id = null)
        {
            if (buildingModel == null || space == null || range == null)
            {
                return null;
            }

            if(!(@enum is ThermostatProfileType || @enum is InternalGainProfileType))
            {
                return null;
            }

            List<SpaceInternalCondition> spaceInternalConditions = buildingModel.GetSpaceInternalConditions(space);
            if (spaceInternalConditions == null)
            {
                return null;
            }

            for (int i = spaceInternalConditions.Count - 1; i >= 0; i--)
            {
                SpaceInternalCondition spaceInternalCondition = spaceInternalConditions[i];

                if (spaceInternalCondition?.Range != null && spaceInternalCondition.Id == id)
                {
                    continue;
                }

                spaceInternalConditions.RemoveAt(i);
            }

            if (spaceInternalConditions == null || spaceInternalConditions.Count == 0)
            {
                return null;
            }

            spaceInternalConditions.Sort((x, y) => x.Range.Min.CompareTo(y.Range.Min));

            IndexedDoubles result = new IndexedDoubles();

            int count_SpaceInternalConditions = spaceInternalConditions.Count;

            for (int i = 0; i < count_SpaceInternalConditions; i++)
            {
                SpaceInternalCondition spaceInternalCondition = spaceInternalConditions[i];

                Range<int> range_Profile = spaceInternalCondition.Range;

                IProfile profile = Query.Profile(spaceInternalCondition.InternalCondition, (dynamic)@enum);

                double[] values_Profile = profile?.Values;
                if (values_Profile == null || values_Profile.Length == 0)
                {
                    for (int j = range_Profile.Min; j >= range_Profile.Max; j++)
                    {
                        result[j] = double.NaN;
                    }

                    continue;
                }

                int count_Profile = values_Profile.Length;

                int max_SpaceInternalCondition = range_Profile.Max;

                int current = 0;
                for (int j = range_Profile.Min; j <= max_SpaceInternalCondition; j++)
                {
                    result[j] = values_Profile[current % count_Profile];
                    current++;
                }

                if (i == count_SpaceInternalConditions - 1)
                {
                    continue;
                }

                int count_Missing = spaceInternalConditions[i + 1].Range.Min - max_SpaceInternalCondition - 1;
                for (int j = 0; j < count_Missing; j++)
                {
                    result[max_SpaceInternalCondition + j + 1] = values_Profile[j % count_Profile];
                }
            }

            int? max = result.GetMaxIndex();
            if (max == null || !max.HasValue)
            {
                return result;
            }

            List<double> values = null;
            int count_Values = -1;

            if (max.Value < range.Max)
            {
                values = result.Values.ToList();
                count_Values = values.Count;

                int count_Missing = range.Max - max.Value;
                for (int j = 0; j < count_Missing; j++)
                {
                    result[max.Value + j + 1] = values[j % count_Values];
                }
            }

            int? min = result.GetMinIndex();
            if (min == null || !min.HasValue)
            {
                return result;
            }

            if (min.Value > range.Min)
            {
                if (values == null)
                {
                    values = result.Values.ToList();
                    count_Values = values.Count;
                }

                int count_Missing = min.Value - range.Min;
                for (int j = 0; j < count_Missing; j++)
                {
                    result[range.Min + j] = values[j % count_Values];
                }
            }

            return result;
        }

        public static IndexedDoubles IndexedDoubles(this BuildingModel buildingModel, ISpace space, Range<int> range, ThermostatProfileType thermostatProfileType, string id = null)
        {
            if(buildingModel == null || space == null || range == null || thermostatProfileType == ThermostatProfileType.Undefined)
            {
                return null;
            }

            return IndexedDoubles(buildingModel, space, range, (System.Enum)thermostatProfileType, id);
        }

        public static IndexedDoubles IndexedDoubles(this BuildingModel buildingModel, ISpace space, int start, int end, ThermostatProfileType thermostatProfileType, string id = null)
        {
            if (buildingModel == null || space == null || thermostatProfileType == ThermostatProfileType.Undefined)
            {
                return null;
            }

            return IndexedDoubles(buildingModel, space, new Range<int>(start, end), (System.Enum)thermostatProfileType, id);
        }

        public static IndexedDoubles IndexedDoubles(this BuildingModel buildingModel, ISpace space, Range<int> range, InternalGainProfileType internalGainProfileType, string id = null)
        {
            if (buildingModel == null || space == null || range == null || internalGainProfileType == InternalGainProfileType.Undefined)
            {
                return null;
            }

            return IndexedDoubles(buildingModel, space, range, (System.Enum)internalGainProfileType, id);
        }

        public static IndexedDoubles IndexedDoubles(this BuildingModel buildingModel, ISpace space, int start, int end, InternalGainProfileType internalGainProfileType, string id = null)
        {
            if (buildingModel == null || space == null || internalGainProfileType == InternalGainProfileType.Undefined)
            {
                return null;
            }

            return IndexedDoubles(buildingModel, space, new Range<int>(start, end), (System.Enum)internalGainProfileType, id);
        }
    }
}