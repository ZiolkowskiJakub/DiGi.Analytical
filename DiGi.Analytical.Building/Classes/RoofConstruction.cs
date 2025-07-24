using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class RoofConstruction : ComponentConstruction<IRoof>, IRoofConstruction
    {
        public RoofConstruction(IStructure structure)
            : base(structure)
        {

        }

        public RoofConstruction(RoofConstruction roofConstruction)
            : base(roofConstruction)
        {

        }
        
        public RoofConstruction(System.Guid guid, RoofConstruction roofConstruction)
            : base(guid, roofConstruction)
        {

        }

        public RoofConstruction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
