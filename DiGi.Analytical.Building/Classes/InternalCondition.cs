using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class InternalCondition : BuildingObject, IInternalCondition
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string description;

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string name;

        [JsonIgnore]
        private Dictionary<string, IProfile> profiles;
        
        public InternalCondition(string name)
            : base()
        {
            this.name = name;
        }

        public InternalCondition(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public InternalCondition(InternalCondition internalCondition)
            : base(internalCondition)
        {
            if (internalCondition != null)
            {
                name = internalCondition.name;
                description = internalCondition.description;
            }
        }

        public InternalCondition(System.Guid guid, InternalCondition internalCondition)
            : base(guid, internalCondition)
        {
            if (internalCondition != null)
            {
                name = internalCondition.name;
                description = internalCondition.description;
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

        [JsonInclude, JsonPropertyName("Profiles"), Description("Profiles")]
        public List<IProfile> Profiles
        {
            get
            {
                return profiles == null ? null : new List<IProfile>(profiles.Values);
            }

            set
            {
                profiles = null;

                if (value == null)
                {
                    return;
                }

                profiles = new Dictionary<string, IProfile>();
                foreach (IProfile profile in value)
                {
                    if (profile?.Category == null)
                    {
                        continue;
                    }

                    profiles[profile.Category] = profile;
                }
            }
        }

        [JsonIgnore]
        public IProfile this[string category]
        {
            get
            {
                return GetProfile(category);
            }
        }

        public IProfile GetProfile(string category)
        {
            if(profiles == null)
            {
                return null;
            }

            if(profiles.TryGetValue(category, out IProfile result))
            {
                return result;
            }

            return null;
        }

        public TProfile GetProfie<TProfile>(string category) where TProfile : IProfile
        {
            IProfile profile = GetProfile(category);

            return profile is TProfile ? (TProfile)profile : default;
        }

        public bool SetProfile(IProfile profile)
        {
            if(profile?.Category == null)
            {
                return false;
            }

            if(profiles == null)
            {
                profiles = new Dictionary<string, IProfile>();
            }

            profiles[profile.Category] = profile;
            return true;
        }
    }
}
