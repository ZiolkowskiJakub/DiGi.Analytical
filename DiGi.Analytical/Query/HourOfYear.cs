using System;

namespace DiGi.Analytical
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the total number of hours that have elapsed since the beginning of the year for the specified date and time.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> value for which to calculate the hour of the year.</param>
        /// <returns>An <see cref="int"/> representing the total number of hours elapsed since January 1st of the current year.</returns>
        public static int HourOfYear(this DateTime dateTime)
        {
            return (int)new TimeSpan((dateTime - new DateTime(dateTime.Year, 1, 1)).Ticks).TotalHours;
        }
    }
}