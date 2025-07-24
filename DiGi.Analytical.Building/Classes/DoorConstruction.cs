using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class DoorConstruction : OpeningConstruction<IDoor>, IDoorConstruction
    {
        public DoorConstruction(ISurface2D surface2D, IStructure structure)
            : base(surface2D, structure)
        {

        }

        public DoorConstruction(ISurface2D surface2D, IStructure frameStructure, IStructure paneStructure)
            : base(surface2D, frameStructure, paneStructure)
        {

        }

        public DoorConstruction(DoorConstruction doorConstruction)
            : base(doorConstruction)
        {

        }

        public DoorConstruction(System.Guid guid, DoorConstruction doorConstruction)
            : base(guid, doorConstruction)
        {

        }

        public DoorConstruction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
