using DiGi.Analytical.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    public class Face : Geometry.Spatial.Classes.PolygonalFace3D, IAnalyticalGeometry
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private readonly Guid guid = Guid.NewGuid();

        [JsonInclude, JsonPropertyName("UniqueReference")]
        private readonly IUniqueReference? uniqueReference;
        public Face(Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D)
            : base(polygonalFace3D)
        {

        }

        public Face(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public Face(Face? face)
            : base(face)
        {
            if (face != null)
            {
                guid = face.Guid;
                uniqueReference = Core.Query.Clone(face.uniqueReference);
            }
        }

        public Face(Guid guid, Face? face)
            : base(face)
        {
            this.guid = guid;

            if (face != null)
            {
                uniqueReference = Core.Query.Clone(face.uniqueReference);
            }
        }

        public Face(IUniqueReference? uniqueReference, Geometry.Spatial.Classes.PolygonalFace3D? polygonalFace3D)
            : base(polygonalFace3D)
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
                return new Face(this);
            }

            return new Face(guid.Value, this);
        }
    }
}
