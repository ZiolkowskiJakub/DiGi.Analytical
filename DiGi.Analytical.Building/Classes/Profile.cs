using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a structural or analytical profile consisting of a collection of numerical values.
    /// </summary>
    public class Profile : SerializableObject, IProfile
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly List<double>? values;

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile"/> class using the specified collection of values.
        /// </summary>
        /// <param name="values">The collection of double-precision floating-point numbers used to initialize the profile. This value can be null.</param>
        public Profile(IEnumerable<double>? values)
            : base()
        {
            this.values = values == null ? null : [.. values];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the profile. This value can be null.</param>
        public Profile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile"/> class by copying the values from an existing <see cref="Profile"/> instance.
        /// </summary>
        /// <param name="profile">The source <see cref="Profile"/> instance to copy data from, or <see langword="null"/>.</param>
        public Profile(Profile? profile)
            : base(profile)
        {
            if (profile != null)
            {
                values = profile.values == null ? null : [.. profile.values];
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the profile.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return values == null ? 0 : values.Count;
            }
        }

        /// <summary>
        /// Gets the collection of numeric values associated with this profile.
        /// </summary>
        [JsonIgnore]
        public double[]? Values
        {
            get
            {
                return values?.ToArray();
            }
        }

        /// <summary>
        /// Gets the value at the specified index of the profile values.
        /// </summary>
        /// <param name="index">The zero-based index of the value to retrieve.</param>
        /// <returns>The double value at the specified index, or <see cref="double.NaN"/> if the internal values collection is null.</returns>
        [JsonIgnore]
        public double this[int index]
        {
            get
            {
                return values == null ? double.NaN : values[index];
            }
        }
    }
}