using DiGi.Analytical.Classes;
using System;

namespace DiGi.Analytical
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new <see cref="HourRange"/> based on the specified day of the week, year, and number of hours.
        /// </summary>
        /// <param name="dayOfWeek">The day of the week to use as the starting point for the range.</param>
        /// <param name="year">The year used to determine the initial hour index.</param>
        /// <param name="hours">The number of hours to include in the range.</param>
        /// <returns>A new instance of <see cref="HourRange"/> representing the calculated time span.</returns>
        public static HourRange HourRange(this DayOfWeek dayOfWeek, int year, int hours)
        {
            int index = Query.FirstHourIndex(dayOfWeek, year);

            return new HourRange(index, index + hours);
        }
    }
}