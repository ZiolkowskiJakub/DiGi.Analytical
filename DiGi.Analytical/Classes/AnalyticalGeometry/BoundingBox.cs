using DiGi.Analytical.Interfaces;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    public class BoundingBox : Geometry.Spatial.Classes.BoundingBox3D, IAnalyticalGeometry
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private readonly Guid guid = Guid.NewGuid();

        [JsonInclude, JsonPropertyName("UniqueReference")]
        private readonly IUniqueReference? uniqueReference;
        public BoundingBox(Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D)
            : base(boundingBox3D)
        {

        }

        public BoundingBox(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public BoundingBox(BoundingBox? boundingBox)
            : base(boundingBox)
        {
            if (boundingBox != null)
            {
                guid = boundingBox.Guid;
                uniqueReference = Core.Query.Clone(boundingBox.uniqueReference);
            }
        }

        public BoundingBox(Guid guid, BoundingBox? boundingBox)
            : base(boundingBox)
        {
            this.guid = guid;

            if (boundingBox != null)
            {
                uniqueReference = Core.Query.Clone(boundingBox.uniqueReference);
            }
        }

        public BoundingBox(IUniqueReference? uniqueReference, Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D)
            : base(boundingBox3D)
        {
            this.uniqueReference = Core.Query.Clone(uniqueReference);
        }

        [JsonIgnore]
        public Guid Guid
        {
            get
            {
                return guid;
            }
        }

        [JsonIgnore]
        public string? UniqueId
        {
            get
            {
                return Core.Query.UniqueId(Guid);
            }
        }

        [JsonIgnore]
        public IUniqueReference? UniqueReference
        {
            get
            {
                return Core.Query.Clone(uniqueReference);
            }
        }
        
        public IGuidObject? Duplicate(Guid? guid = null)
        {
            if (guid is null)
            {
                return new BoundingBox(this);
            }

            return new BoundingBox(guid.Value, this);
        }
    }
}
