using System;

namespace DiGi.Analytical
{
    public static partial class Create
    {
        public static DateTime DateTime(this int year, int hourOfYear)
        {
            return new DateTime(year, 1, 1).AddHours(hourOfYear);
        }

    }
}

