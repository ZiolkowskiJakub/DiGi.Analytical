using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class Wall<T> : BuildingGeometryObject<T>, IWall<T> where T : IGeometry3D
    {
        public Wall(T geometry)
            :base(geometry)
        {

        }

        public Wall(Wall<T> wall)
            : base(wall)
        {
            wall.StructurePosition = StructurePosition;
        }

        public Wall(System.Guid guid, Wall<T> wall)
            : base(guid, wall)
        {
            wall.StructurePosition = StructurePosition;
        }

        public Wall(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("StructurePosition"), Description("StructurePosition")]
        public StructurePosition StructurePosition { get; set; }
    }
}
