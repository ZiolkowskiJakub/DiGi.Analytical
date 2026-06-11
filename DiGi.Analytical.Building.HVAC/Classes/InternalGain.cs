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
    /// <summary>
    /// Represents the internal heat gain parameters for a building space, including radiant proportions and view coefficients for lighting, occupants, and equipment.
    /// </summary>
    public class InternalGain : ParametrizedObject, IHVACNamedObject
    {
        /// <summary>
        /// Gets or sets the description of the internal gain.
        /// </summary>
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the internal gain.
        /// </summary>
        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the proportion of lighting heat gain that is radiant.
        /// </summary>
        [JsonInclude, JsonPropertyName("LightingRadiantProportion"), Description("LightingRadiantProportion [0-1]")]
        public Factor LightingRadiantProportion { get; set; }

        /// <summary>
        /// Gets or sets the proportion of occupant internal heat gain that is radiant, expressed as a factor between 0 and 1.
        /// </summary>
        [JsonInclude, JsonPropertyName("OccupantRadiantProportion"), Description("OccupantRadiantProportion [0-1]")]
        public Factor OccupantRadiantProportion { get; set; }

        /// <summary>
        /// Gets or sets the proportion of equipment internal heat gain that is radiant, expressed as a factor between 0 and 1.
        /// </summary>
        [JsonInclude, JsonPropertyName("EquipmentRadiantProportion"), Description("EquipmentRadiantProportion [0-1]")]
        public Factor EquipmentRadiantProportion { get; set; }

        /// <summary>
        /// Gets or sets the lighting view coefficient, represented as a factor between 0 and 1.
        /// </summary>
        [JsonInclude, JsonPropertyName("LightingViewCoefficient"), Description("LightingViewCoefficient [0-1]")]
        public Factor LightingViewCoefficient { get; set; }

        /// <summary>
        /// Gets or sets the view coefficient for occupant internal gains, representing a normalization factor between 0 and 1.
        /// </summary>
        [JsonInclude, JsonPropertyName("OccupantViewCoefficient"), Description("OccupantViewCoefficient [0-1]")]
        public Factor OccupantViewCoefficient { get; set; }

        /// <summary>
        /// Gets or sets the view coefficient for equipment internal gains, represented as a factor between 0 and 1.
        /// </summary>
        [JsonInclude, JsonPropertyName("EquipmentViewCoefficient"), Description("EquipmentViewCoefficient [0-1]")]
        public Factor EquipmentViewCoefficient { get; set; }

        [JsonInclude, JsonPropertyName("Profiles"), Description("Profiles")]
        private Dictionary<InternalGainProfileType, IProfile>? profiles;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalGain"/> class.
        /// </summary>
        public InternalGain()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalGain"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the initialization data, or <see langword="null"/>.</param>
        public InternalGain(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalGain"/> class by copying values from an existing <see cref="InternalGain"/> instance.
        /// </summary>
        /// <param name="internalGain">The source <see cref="InternalGain"/> instance to copy data from, or <see langword="null"/>.</param>
        public InternalGain(InternalGain? internalGain)
            : base(internalGain)
        {
            if (internalGain != null)
            {
                Name = internalGain.Name;
                Description = internalGain.Description;

                if (internalGain.profiles != null)
                {
                    profiles = [];
                    foreach (KeyValuePair<InternalGainProfileType, IProfile> keyValuePair in profiles)
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
        /// Gets or sets the profile associated with the specified internal gain profile type.
        /// </summary>
        /// <param name="internalGainProfileType">The type of the internal gain profile to retrieve or set.</param>
        /// <returns>The <see cref="IProfile"/> associated with the specified profile type, or <see langword="null"/> if no such profile exists.</returns>
        public IProfile? this[InternalGainProfileType internalGainProfileType]
        {
            get
            {
                if (profiles == null)
                {
                    return null;
                }

                if (profiles.TryGetValue(internalGainProfileType, out IProfile result))
                {
                    return result;
                }

                return null;
            }

            set
            {
                profiles ??= [];

                if (value == null)
                {
                    return;
                }

                profiles[internalGainProfileType] = value;
            }
        }
    }
}