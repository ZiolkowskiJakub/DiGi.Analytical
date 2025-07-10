using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
namespace DiGi.Analytical.Building.Classes
{
    public class Profile : BuildingObject, IProfile
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string description;

        [JsonInclude, JsonPropertyName("IndexDoubles")]
        private IndexedDoubles indexDoubles;

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string name;
        
        public Profile()
            : base()
        {

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
                indexDoubles = Core.Query.Clone(profile.indexDoubles);
                name = profile.name;
            }
        }

        public Profile(System.Guid guid, Profile profile)
            : base(guid, profile)
        {
            if (profile != null)
            {
                indexDoubles = Core.Query.Clone(profile.indexDoubles);
                name = profile.name;
            }
        }

        [JsonIgnore]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
