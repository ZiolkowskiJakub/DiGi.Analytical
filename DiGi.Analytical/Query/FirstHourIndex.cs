using System;

namespace DiGi.Analytical
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the index of the first hour of the specified year that occurs on the given day of the week.
        /// </summary>
        /// <param name="dayOfWeek">The day of the week to search for.</param>
        /// <param name="year">The calendar year to evaluate.</param>
        /// <returns>The index of the first hour of the year that falls on the specified day of the week.</returns>
        public static int FirstHourIndex(this DayOfWeek dayOfWeek, int year)
        {
            DateTime dateTime = new(year, 1, 1, 0, 0, 0);

            while (dateTime.DayOfWeek != dayOfWeek)
            {
                dateTime = dateTime.AddDays(1);
            }

            return HourOfYear(dateTime);
        }
    }
}