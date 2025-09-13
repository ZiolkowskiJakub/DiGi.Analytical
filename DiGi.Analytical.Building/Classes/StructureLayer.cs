using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class StructureLayer : GuidObject, IStructureLayer
    {
        public StructureLayer(StructureLayer? structureLayer)
            : base(structureLayer)
        {

        }

        public StructureLayer(int index, double thickness)
            : base()
        {
            Index = index;
            Thickness = thickness;
        }

        public StructureLayer(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public int Index { get; set; }

        public double Thickness { get; set; }
    }
}
