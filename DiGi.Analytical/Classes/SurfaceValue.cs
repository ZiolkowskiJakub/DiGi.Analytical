using DiGi.Analytical.Interfaces;
using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    public class SurfaceValue : SerializableObject, IAnalyticalObject
    {
        [JsonIgnore]
        private double @internal;

        [JsonIgnore]
        private double external;

        public SurfaceValue(double @internal, double external)
            :base()
        {
            this.@internal = @internal;
            this.external = external;
        }

        public SurfaceValue(SurfaceValue? surfaceValue)
            :base(surfaceValue)
        {
            if(surfaceValue is not null)
            {
                @internal = surfaceValue.@internal;
                external = surfaceValue.external;
            }
        }

        public SurfaceValue(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

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
