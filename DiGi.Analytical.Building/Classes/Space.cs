using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class Space : BuildingGeometryObject<Point3D>, ISpace
    {
        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string name;

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Space(Point3D geometry, string name)
            :base(geometry)
        {
            this.name = name;
        }

        public Space(JsonObject jsonObject)
            : base(jsonObject)
        {
           
        }

        public Space(Space space)
            : base(space)
        {
            if(space != null)
            {
                name = space.name;
            }
        }
    }
}
