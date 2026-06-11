using System;

namespace DiGi.Analytical
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="DateTime"/> instance based on the specified year and the number of hours elapsed since the start of that year.
        /// </summary>
        /// <param name="year">The calendar year.</param>
        /// <param name="hourOfYear">The number of hours to add to January 1st of the specified year.</param>
        /// <returns>A <see cref="DateTime"/> object representing the calculated date and time.</returns>
        public static DateTime DateTime(this int year, int hourOfYear)
        {
            return new DateTime(year, 1, 1).AddHours(hourOfYear);
        }
    }
}