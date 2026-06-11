using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a material specifically characterized as being in a solid state.
    /// </summary>
    public class SolidMaterial : Material
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolidMaterial"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the solid material.</param>
        public SolidMaterial(string? name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolidMaterial"/> class using an existing <see cref="SolidMaterial"/> object.
        /// </summary>
        /// <param name="solidMaterial">The source <see cref="SolidMaterial"/> instance to copy from.</param>
        public SolidMaterial(SolidMaterial? solidMaterial)
            : base(solidMaterial)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolidMaterial"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the material.</param>
        public SolidMaterial(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}