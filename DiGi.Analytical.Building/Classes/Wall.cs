using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class Wall<T> : Component<T>, IWall<T> where T : IGeometry3D
    {
        public Wall(T geometry)
            :base(geometry)
        {

        }

        public Wall(Wall<T> wall)
            : base(wall)
        {

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
    }
}
