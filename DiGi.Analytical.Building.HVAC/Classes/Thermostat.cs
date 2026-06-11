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
    /// <summary>
    /// Represents a thermostat device used for controlling heating, ventilation, and air conditioning (HVAC) systems within a building analytical model.
    /// </summary>
    public class Thermostat : ParametrizedObject, IHVACNamedObject
    {
        /// <summary>Gets or sets the description of the thermostat.</summary>
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the thermostat.
        /// </summary>
        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        public string? Name { get; set; }

        [JsonInclude, JsonPropertyName("Profiles"), Description("Profiles")]
        private Dictionary<ThermostatProfileType, IProfile>? profiles;

        /// <summary>
        /// Initializes a new instance of the <see cref="Thermostat"/> class.
        /// </summary>
        public Thermostat()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thermostat"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the thermostat instance.</param>
        public Thermostat(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thermostat"/> class by copying the properties and profiles from an existing thermostat instance.
        /// </summary>
        /// <param name="thermostat">The source <see cref="Thermostat"/> instance to copy data from, or <see langword="null"/>.</param>
        public Thermostat(Thermostat? thermostat)
            : base(thermostat)
        {
            if (thermostat != null)
            {
                Name = thermostat.Name;
                Description = thermostat.Description;

                if (thermostat.profiles != null)
                {
                    profiles = [];
                    foreach (KeyValuePair<ThermostatProfileType, IProfile> keyValuePair in profiles)
                    {
                        if (Core.Query.Clone(keyValuePair.Value) is IProfile profile)
                        {
                            profiles[keyValuePair.Key] = profile;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the profile associated with the specified thermostat profile type.
        /// </summary>
        /// <param name="thermostatProfileType">The type of the thermostat profile to retrieve or assign.</param>
        /// <returns>The <see cref="IProfile"/> associated with the specified profile type, or <see langword="null"/> if no such profile exists.</returns>
        public IProfile? this[ThermostatProfileType thermostatProfileType]
        {
            get
            {
                if (profiles == null)
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
                if (value is null)
                {
                    return;
                }

                profiles ??= [];

                profiles[thermostatProfileType] = value;
            }
        }
    }
}