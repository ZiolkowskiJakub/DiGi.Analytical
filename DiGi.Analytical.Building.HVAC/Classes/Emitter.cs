using DiGi.Analytical.Building.HVAC.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Parameter.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.HVAC.Classes
{
    /// <summary>
    /// Represents an abstract base class for HVAC emitter components, defining core properties for thermal radiation and operational temperature thresholds.
    /// </summary>
    public abstract class Emitter : ParametrizedObject, IHVACNamedObject
    {
        /// <summary>
        /// Gets or sets the description of the emitter.
        /// </summary>
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the emitter.
        /// </summary>
        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the radiant proportion of the emitter as a value between 0 and 1.
        /// </summary>
        [JsonInclude, JsonPropertyName("RadiantProportion"), Description("RadiantProportion [0-1]")]
        public Factor RadiantProportion { get; set; }

        /// <summary>
        /// Gets or sets the view coefficient of the emitter as a normalization factor between 0 and 1.
        /// </summary>
        [JsonInclude, JsonPropertyName("ViewCoefficient"), Description("ViewCoefficient [0-1]")]
        public Factor ViewCoefficient { get; set; }

        /// <summary>
        /// Gets or sets the maximum outside temperature.
        /// </summary>
        [JsonInclude, JsonPropertyName("MaxOutsideTemperature"), Description("Max outside temperature")]
        public double MaxOutsideTemperature { get; set; }

        /// <summary>
        /// Gets or sets the outside temperature threshold at which the emitter is turned off.
        /// </summary>
        [JsonInclude, JsonPropertyName("OffOutsideTemperature"), Description("Off outside temperature")]
        public double OffOutsideTemperature { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Emitter"/> class.
        /// </summary>
        public Emitter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Emitter"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the properties of the emitter; may be <see langword="null"/>.</param>
        public Emitter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Emitter"/> class by copying the properties from another <see cref="Emitter"/> instance.
        /// </summary>
        /// <param name="emitter">The source <see cref="Emitter"/> object to copy values from; if null, only base class initialization is performed.</param>
        public Emitter(Emitter? emitter)
            : base(emitter)
        {
            if (emitter != null)
            {
                Name = emitter.Name;
                Description = emitter.Description;
                RadiantProportion = Core.Query.Clone(emitter.RadiantProportion);
                ViewCoefficient = Core.Query.Clone(emitter.ViewCoefficient);
                MaxOutsideTemperature = emitter.MaxOutsideTemperature;
                OffOutsideTemperature = emitter.OffOutsideTemperature;
            }
        }
    }
}