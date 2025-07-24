using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class WindowConstruction : OpeningConstruction<IWindow>, IWindowConstruction
    {
        public WindowConstruction(string name, ISurface2D surface2D, IStructure frameStructure, IStructure paneStructure)
            : base(name,surface2D, frameStructure, paneStructure)
        {

        }

        public WindowConstruction(WindowConstruction windowConstruction)
            : base(windowConstruction)
        {

        }

        public WindowConstruction(System.Guid guid, WindowConstruction windowConstruction)
            : base(guid, windowConstruction)
        {

        }

        public WindowConstruction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
