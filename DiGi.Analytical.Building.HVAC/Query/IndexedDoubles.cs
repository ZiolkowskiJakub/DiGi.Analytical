using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.HVAC
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a collection of indexed double-precision floating-point values for a specific space and profile type within the building model.
        /// </summary>
        /// <param name="buildingModel">The <see cref="BuildingModel"/> instance to query.</param>
        /// <param name="space">The <see cref="ISpace"/> associated with the data retrieval.</param>
        /// <param name="range">The <see cref="Range{T}"/> of integers defining the index range.</param>
        /// <param name="enum">The enumeration value specifying the profile type, such as <see cref="ThermostatProfileType"/> or <see cref="InternalGainProfileType"/>.</param>
        /// <param name="id">An optional unique identifier for the internal condition.</param>
        /// <returns>An <see cref="Core.Classes.IndexedDoubles"/> instance if matching data is found; otherwise, <c>null</c>.</returns>
        public static IndexedDoubles? IndexedDoubles(this BuildingModel? buildingModel, ISpace? space, Range<int>? range, System.Enum? @enum, string? id = null)
        {
            if (buildingModel == null || space == null || range == null)
            {
                return null;
            }

            if (!(@enum is ThermostatProfileType || @enum is InternalGainProfileType))
            {
                return null;
            }

            List<SpaceInternalCondition>? spaceInternalConditions = buildingModel.GetSpaceInternalConditions(space);
            if (spaceInternalConditions == null)
            {
                return null;
            }

            for (int i = spaceInternalConditions.Count - 1; i >= 0; i--)
            {
                SpaceInternalCondition spaceInternalCondition = spaceInternalConditions[i];

                if (spaceInternalCondition?.HourRange != null && spaceInternalCondition.Id == id)
                {
                    continue;
                }

                spaceInternalConditions.RemoveAt(i);
            }

            if (spaceInternalConditions == null || spaceInternalConditions.Count == 0)
            {
                return null;
            }

            spaceInternalConditions.Sort((x, y) => x.HourRange!.Min.CompareTo(y.HourRange!.Min));

            IndexedDoubles result = [];

            int count_SpaceInternalConditions = spaceInternalConditions.Count;

            for (int i = 0; i < count_SpaceInternalConditions; i++)
            {
                SpaceInternalCondition spaceInternalCondition = spaceInternalConditions[i];

                Range<int> range_Profile = spaceInternalCondition.HourRange!;

                IProfile profile = Query.Profile(spaceInternalCondition.InternalCondition, (dynamic)@enum);

                double[]? values_Profile = profile?.Values;
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

                int count_Missing = spaceInternalConditions[i + 1].HourRange!.Min - max_SpaceInternalCondition - 1;
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

            List<double>? values = null;
            int count_Values = -1;

            if (max.Value < range.Max)
            {
                values = [.. result.Values!];
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
                    values = [.. result.Values!];
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

        /// <summary>
        /// Retrieves a collection of double-precision floating-point values mapped to integer indices for a specified thermostat profile within a building space.
        /// </summary>
        /// <param name="buildingModel">The building model containing the data.</param>
        /// <param name="space">The space associated with the thermostat profile.</param>
        /// <param name="range">The range of indices to retrieve.</param>
        /// <param name="thermostatProfileType">The type of thermostat profile to query.</param>
        /// <param name="id">An optional identifier for the specific profile or data source.</param>
        /// <returns>An <see cref="Core.Classes.IndexedDoubles"/> instance containing the retrieved values, or <c>null</c> if the building model, space, range, or profile type is invalid or undefined.</returns>
        public static IndexedDoubles? IndexedDoubles(this BuildingModel? buildingModel, ISpace? space, Range<int>? range, ThermostatProfileType thermostatProfileType, string? id = null)
        {
            if (buildingModel == null || space == null || range == null || thermostatProfileType == ThermostatProfileType.Undefined)
            {
                return null;
            }

            return IndexedDoubles(buildingModel, space, range, (System.Enum)thermostatProfileType, id);
        }

        /// <summary>
        /// Retrieves a collection of double-precision floating-point values mapped to integer indices for a specified thermostat profile within a given space and range.
        /// </summary>
        /// <param name="buildingModel">The building model containing the data.</param>
        /// <param name="space">The space associated with the thermostat profile.</param>
        /// <param name="start">The starting index of the requested range.</param>
        /// <param name="end">The ending index of the requested range.</param>
        /// <param name="thermostatProfileType">The type of thermostat profile to be retrieved.</param>
        /// <param name="id">An optional identifier for the specific profile instance.</param>
        /// <returns>An <see cref="Core.Classes.IndexedDoubles"/> instance containing the values if successful; otherwise, <c>null</c>.</returns>
        public static IndexedDoubles? IndexedDoubles(this BuildingModel? buildingModel, ISpace? space, int start, int end, ThermostatProfileType thermostatProfileType, string? id = null)
        {
            if (buildingModel == null || space == null || thermostatProfileType == ThermostatProfileType.Undefined)
            {
                return null;
            }

            return IndexedDoubles(buildingModel, space, new Range<int>(start, end), (System.Enum)thermostatProfileType, id);
        }

        /// <summary>
        /// Retrieves a collection of double-precision floating-point values for the specified internal gain profile within a given space and index range.
        /// </summary>
        /// <param name="buildingModel">The building model to query.</param>
        /// <param name="space">The space from which to retrieve the data.</param>
        /// <param name="range">The range of indices for the values to be retrieved.</param>
        /// <param name="internalGainProfileType">The type of internal gain profile to query.</param>
        /// <param name="id">An optional identifier used to filter or specify the data source.</param>
        /// <returns>An <see cref="Core.Classes.IndexedDoubles"/> instance containing the retrieved values, or <c>null</c> if any required parameters are null or invalid.</returns>
        public static IndexedDoubles? IndexedDoubles(this BuildingModel? buildingModel, ISpace? space, Range<int>? range, InternalGainProfileType internalGainProfileType, string? id = null)
        {
            if (buildingModel == null || space == null || range == null || internalGainProfileType == InternalGainProfileType.Undefined)
            {
                return null;
            }

            return IndexedDoubles(buildingModel, space, range, (System.Enum)internalGainProfileType, id);
        }

        /// <summary>
        /// Retrieves a collection of double-precision floating-point values mapped to integer indices for a specific internal gain profile within a specified range.
        /// </summary>
        /// <param name="buildingModel">The building model containing the data.</param>
        /// <param name="space">The space associated with the internal gain profile.</param>
        /// <param name="start">The starting index of the value range to retrieve.</param>
        /// <param name="end">The ending index of the value range to retrieve.</param>
        /// <param name="internalGainProfileType">The type of internal gain profile to be retrieved.</param>
        /// <param name="id">An optional identifier for the specific internal gain profile.</param>
        /// <returns>An <see cref="Core.Classes.IndexedDoubles"/> instance containing the values if successful; otherwise, <c>null</c>.</returns>
        public static IndexedDoubles? IndexedDoubles(this BuildingModel? buildingModel, ISpace? space, int start, int end, InternalGainProfileType internalGainProfileType, string? id = null)
        {
            if (buildingModel == null || space == null || internalGainProfileType == InternalGainProfileType.Undefined)
            {
                return null;
            }

            return IndexedDoubles(buildingModel, space, new Range<int>(start, end), (System.Enum)internalGainProfileType, id);
        }
    }
}