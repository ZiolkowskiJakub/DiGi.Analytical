using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class SolidMaterial : Material
    {
        public SolidMaterial(string? name)
            : base(name)
        {
        }

        public SolidMaterial(SolidMaterial? solidMaterial)
            : base(solidMaterial)
        {
        }

        public SolidMaterial(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}