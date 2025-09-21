using DiGi.Analytical.Interfaces;
using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    public class Shell : Geometry.Spatial.Classes.Polyhedron<Face>, IAnalyticalGeometry
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private readonly Guid guid = Guid.NewGuid();

        [JsonInclude, JsonPropertyName("UniqueReference")]
        private readonly IUniqueReference? uniqueReference;
        public Shell(Shell shell)
            : base(shell)
        {
            if(shell is not null)
            {
                guid = shell.guid;
                uniqueReference = Core.Query.Clone(shell.UniqueReference);
            }
        }

        public Shell(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public Shell(IUniqueReference? uniqueReference, IEnumerable<Face> faces)
            : base(faces)
        {
            this.uniqueReference = Core.Query.Clone(uniqueReference);
        }

        public Shell(Guid guid, Shell? shell)
            : base(shell)
        {
            this.guid = guid;

            if (shell != null)
            {
                uniqueReference = Core.Query.Clone(shell.uniqueReference);
            }
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
                return new Shell(this);
            }

            return new Shell(guid.Value, this);
        }
    }
}
