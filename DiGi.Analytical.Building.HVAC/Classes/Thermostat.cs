using DiGi.Analytical.Building.HVAC.Enums;
using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    public class Thermostat : ParametrizedObject, IHVACNamedObject
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        public string Description { get; set; }

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        public string Name { get; set; }

        [JsonInclude, JsonPropertyName("Profiles"), Description("Profiles")]
        private Dictionary<ThermostatProfileType, IProfile> profiles;

        public Thermostat()
            : base()
        {

        }

        public Thermostat(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Thermostat(Thermostat thermostat)
            : base(thermostat)
        {
            if (thermostat != null)
            {
                Name = thermostat.Name;
                Description = thermostat.Description;

                if (thermostat.profiles != null)
                {
                    profiles = new Dictionary<ThermostatProfileType, IProfile>();
                    foreach (KeyValuePair<ThermostatProfileType, IProfile> keyValuePair in profiles)
                    {
                        profiles[keyValuePair.Key] = Core.Query.Clone(keyValuePair.Value);
                    }
                }
            }
        }

        public IProfile this[ThermostatProfileType thermostatProfileType]
        {
            get
            {
                if(profiles == null)
                {
                    return null;
                }

                if (profiles.TryGetValue(thermostatProfileType, out IProfile result))
                {
                    return result;
                }

                return null;
            }

            set
            {
                if(profiles == null)
                {
                    profiles = new Dictionary<ThermostatProfileType, IProfile>();
                }

                profiles[thermostatProfileType] = value;
            }
        }
    }
}
