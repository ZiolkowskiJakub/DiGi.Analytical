using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a range of hours defined by integer values.
    /// </summary>
    public class HourRange : Range<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HourRange"/> class using the specified range.
        /// </summary>
        /// <param name="range">The <see cref="Range{T}"/> used to initialize this instance.</param>
        public HourRange(Range<int>? range)
            : base(range)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HourRange"/> class with specified start and end values.
        /// </summary>
        /// <param name="value_1">The starting hour value.</param>
        /// <param name="value_2">The ending hour value.</param>
        public HourRange(int value_1, int value_2)
            : base(value_1, value_2)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HourRange"/> class using the values from an existing <see cref="HourRange"/> instance.
        /// </summary>
        /// <param name="hourRange">The source <see cref="HourRange"/> instance to copy values from.</param>
        public HourRange(HourRange? hourRange)
            : base(hourRange)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HourRange"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the hour range.</param>
        public HourRange(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}