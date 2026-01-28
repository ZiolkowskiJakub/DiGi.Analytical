using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class FluidMaterial : Material
    {
        public FluidMaterial(string? name)
            : base(name)
        {
        }

        public FluidMaterial(FluidMaterial? fluidMaterial)
            : base(fluidMaterial)
        {
        }

        public FluidMaterial(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}