using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class Profile : SerializableObject, IProfile
    {
        [JsonInclude, JsonPropertyName("Values")]
        private List<double> values;

        public Profile(IEnumerable<double> values)
            : base()
        {
            this.values = values == null ? null : new List<double>(values);
        }

        public Profile(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Profile(Profile profile)
            : base(profile)
        {
            if (profile != null)
            {
                values = profile.values == null ? null : new List<double>(profile.values);
            }
        }

        [JsonIgnore]
        public int Count
        {
            get
            {
                return values == null ? 0 : values.Count;
            }
        }

        [JsonIgnore]
        public double[] Values
        {
            get
            {
                return values?.ToArray();
            }
        }

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
