using DiGi.Analytical.Classes;
using System;

namespace DiGi.Analytical
{
    public static partial class Create
    {
        public static HourRange HourRange(this DayOfWeek dayOfWeek, int year, int hours)
        {
            int index = Query.FirstHourIndex(dayOfWeek, year);

            return new HourRange(index, index + hours);
        }

    }
}

