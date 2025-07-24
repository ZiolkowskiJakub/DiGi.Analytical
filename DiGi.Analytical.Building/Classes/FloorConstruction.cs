using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class FloorConstruction : ComponentConstruction<IFloor>, IFloorConstruction
    {
        public FloorConstruction(IStructure structure)
            : base(structure)
        {

        }

        public FloorConstruction(FloorConstruction floorConstruction)
            : base(floorConstruction)
        {

        }

        public FloorConstruction(System.Guid guid, FloorConstruction floorConstruction)
            : base(guid, floorConstruction)
        {

        }

        public FloorConstruction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
