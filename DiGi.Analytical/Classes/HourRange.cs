using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class HourRange : Range<int>
    {
        public HourRange(Range<int> range)
            :base(range)
        {

        }

        public HourRange(int value_1, int value_2)
            :base(value_1, value_2)
        {

        }

        public HourRange(HourRange hourRange)
            :base(hourRange)
        {

        }

        public HourRange(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
