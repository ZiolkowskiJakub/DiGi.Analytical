using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class Profile : SerializableObject, IProfile
    {
        [JsonInclude, JsonPropertyName("Category")]
        private string category;

        [JsonInclude, JsonPropertyName("Values")]
        private List<double> values;

        public Profile(string category, IEnumerable<double> values)
            : base()
        {
            this.category = category;
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
                category = profile.category;
            }
        }

        [JsonIgnore]
        public string Category
        {
            get
            {
                return category;
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
