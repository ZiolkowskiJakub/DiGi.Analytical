using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class WallConstruction : ComponentConstruction<IWall>, IWallConstruction
    {
        public WallConstruction(IStructure structure)
            : base(structure)
        {

        }

        public WallConstruction(WallConstruction wallConstruction)
            : base(wallConstruction)
        {

        }

        public WallConstruction(System.Guid guid, WallConstruction wallConstruction)
            : base(guid, wallConstruction)
        {

        }

        public WallConstruction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
