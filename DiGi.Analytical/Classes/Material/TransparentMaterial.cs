using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    public class TransparentMaterial : SolidMaterial
    {
        public TransparentMaterial(string? name)
            : base(name)
        {

        }

        public TransparentMaterial(TransparentMaterial? transparentMaterial)
            :base(transparentMaterial)
        {

        }

        public TransparentMaterial(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }
    }
}
