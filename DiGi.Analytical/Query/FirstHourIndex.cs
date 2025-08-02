using System;

namespace DiGi.Analytical
{
    public static partial class Query
    {
        public static int FirstHourIndex(this DayOfWeek dayOfWeek, int year)
        {
            DateTime dateTime = new DateTime(year, 1, 1, 0, 0, 0);

            while(dateTime.DayOfWeek != dayOfWeek)
            {
                dateTime = dateTime.AddDays(1);
            }

            return HourOfYear(dateTime);
        }
    }
}