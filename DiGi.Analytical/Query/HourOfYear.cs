using System;

namespace DiGi.Analytical
{
    public static partial class Query
    {
        public static int HourOfYear(this DateTime dateTime)
        {
            return (int)new TimeSpan((dateTime - new DateTime(dateTime.Year, 1, 1)).Ticks).TotalHours;
        }
    }
}