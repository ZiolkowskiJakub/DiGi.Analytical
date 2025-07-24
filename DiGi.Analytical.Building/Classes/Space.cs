using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class Space : BuildingGeometry3DObject<Point3D>, ISpace
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string description;

        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string name;
        
        public Space(Point3D geometry, string name)
            : base(geometry)
        {
            this.name = name;
        }

        public Space(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Space(System.Guid guid, Space space)
            : base(guid, space)
        {
            if (space != null)
            {
                name = space.name;
                description = space.description;
            }
        }

        public Space(Space space)
            : base(space)
        {
            if (space != null)
            {
                name = space.name;
                description = space.description;
            }
        }

        [JsonIgnore]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
