using DiGi.Analytical.Interfaces;
using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a value associated with a surface, containing both internal and external numeric measurements.
    /// </summary>
    public class SurfaceValue : SerializableObject, IAnalyticalObject
    {
        [JsonIgnore]
        private double @internal;

        [JsonIgnore]
        private double external;

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceValue"/> class with specified internal and external values.
        /// </summary>
        /// <param name="internal">The internal value to assign.</param>
        /// <param name="external">The external value to assign.</param>
        public SurfaceValue(double @internal, double external)
            : base()
        {
            this.@internal = @internal;
            this.external = external;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceValue"/> class by copying values from an existing <see cref="SurfaceValue"/> instance.
        /// </summary>
        /// <param name="surfaceValue">The source <see cref="SurfaceValue"/> instance to copy data from, or null.</param>
        public SurfaceValue(SurfaceValue? surfaceValue)
            : base(surfaceValue)
        {
            if (surfaceValue is not null)
            {
                @internal = surfaceValue.@internal;
                external = surfaceValue.external;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceValue"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to populate the properties of the instance; can be null.</param>
        public SurfaceValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the value associated with the external side of the surface.
        /// </summary>
        [JsonInclude, JsonPropertyName("External"), Description("External")]
        public double External
        {
            get
            {
                return external;
            }

            set
            {
                external = value;
            }
        }

        /// <summary>
        /// Gets or sets the value for the internal side of the surface.
        /// </summary>
        [JsonInclude, JsonPropertyName("Internal"), Description("Internal")]
        public double Internal
        {
            get
            {
                return @internal;
            }

            set
            {
                @internal = value;
            }
        }
    }
}
