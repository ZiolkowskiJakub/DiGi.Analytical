using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Parameter.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class InternalGain : ParametrizedObject, IHVACNamedObject
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        public string Description { get; set; }

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        public string Name { get; set; }

        [JsonInclude, JsonPropertyName("LightingRadiantProportion"), Description("LightingRadiantProportion [0-1]")]
        public Factor LightingRadiantProportion { get; set; }

        [JsonInclude, JsonPropertyName("OccupantRadiantProportion"), Description("OccupantRadiantProportion [0-1]")]
        public Factor OccupantRadiantProportion { get; set; }

        [JsonInclude, JsonPropertyName("EquipmentRadiantProportion"), Description("EquipmentRadiantProportion [0-1]")]
        public Factor EquipmentRadiantProportion { get; set; }

        [JsonInclude, JsonPropertyName("LightingViewCoefficient"), Description("LightingViewCoefficient [0-1]")]
        public Factor LightingViewCoefficient { get; set; }

        [JsonInclude, JsonPropertyName("OccupantViewCoefficient"), Description("OccupantViewCoefficient [0-1]")]
        public Factor OccupantViewCoefficient { get; set; }

        [JsonInclude, JsonPropertyName("EquipmentViewCoefficient"), Description("EquipmentViewCoefficient [0-1]")]
        public Factor EquipmentViewCoefficient { get; set; }

        [JsonInclude, JsonPropertyName("Profiles"), Description("Profiles")]
        private Dictionary<InternalGainProfileType, IProfile> profiles;

        public InternalGain()
            : base()
        {

        }

        public InternalGain(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public InternalGain(InternalGain internalGain)
            : base(internalGain)
        {
            if (internalGain != null)
            {
                Name = internalGain.Name;
                Description = internalGain.Description;

                if(internalGain.profiles != null)
                {
                    profiles = new Dictionary<InternalGainProfileType, IProfile>();
                    foreach(KeyValuePair<InternalGainProfileType, IProfile> keyValuePair in profiles)
                    {
                        profiles[keyValuePair.Key] = Core.Query.Clone(keyValuePair.Value);
                    }
                }
            }
        }

        public IProfile this[InternalGainProfileType internalGainProfileType]
        {
            get
            {
                if(profiles == null)
                {
                    return null;
                }

                if(profiles.TryGetValue(internalGainProfileType, out IProfile result))
                {
                    return result;
                }

                return null;
            }

            set
            {
                if(profiles == null)
                {
                    profiles = new Dictionary<InternalGainProfileType, IProfile>();
                }

                profiles[internalGainProfileType] = value;
            }
        }
    }
}
