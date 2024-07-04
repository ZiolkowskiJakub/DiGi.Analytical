using DiGi.Analytical.Interfaces;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Parameter.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    public abstract class AnalyticalGeometry : UniqueParametrizedObject, IAnalyticalGeometry
    {
        [JsonInclude, JsonPropertyName("UniqueReference"), Description("UniqueReference")]
        private UniqueReference uniqueReference;

        [JsonIgnore]
        public UniqueReference UniqueReference
        {
            get
            {
                return uniqueReference.Clone<UniqueReference>();
            }
        }

        public AnalyticalGeometry()
            : base()
        {

        }

        public AnalyticalGeometry(UniqueReference uniqueReference)
            : base()
        {
            this.uniqueReference = uniqueReference?.Clone<UniqueReference>();
        }

        public AnalyticalGeometry(System.Guid guid)
            : base(guid)
        {

        }

        public AnalyticalGeometry(AnalyticalGeometry analyticalGeometry)
            : base(analyticalGeometry)
        {
            if (analyticalGeometry != null)
            {
                uniqueReference = analyticalGeometry.UniqueReference?.Clone<UniqueReference>();
            }
        }

        public AnalyticalGeometry(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }

    public abstract class AnalyticalGeometry<T> : AnalyticalGeometry, IAnalyticalGeometry<T> where T : IGeometry3D
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        private T geometry;

        [JsonIgnore]
        public T Geometry
        {
            get
            {
                if(geometry == null)
                {
                    return default;
                }

                return geometry.Clone<T>();
            }
        }

        public AnalyticalGeometry()
            :base()
        {

        }

        public AnalyticalGeometry(T geometry)
            : base()
        {
            if(geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public AnalyticalGeometry(UniqueReference uniqueReference, T geometry)
            : base(uniqueReference)
        {
            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public AnalyticalGeometry(UniqueReference uniqueReference)
            : base(uniqueReference)
        {

        }

        public AnalyticalGeometry(System.Guid guid, T geometry)
            : base(guid)
        {
            if (geometry != null)
            {
                this.geometry = geometry.Clone<T>();
            }
        }

        public AnalyticalGeometry(AnalyticalGeometry<T> analyticalGeometry)
            : base(analyticalGeometry)
        {
            if(analyticalGeometry != null)
            {
                if(analyticalGeometry.geometry != null)
                {
                    geometry = analyticalGeometry.geometry.Clone<T>();
                }
            }
        }

        public AnalyticalGeometry(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
