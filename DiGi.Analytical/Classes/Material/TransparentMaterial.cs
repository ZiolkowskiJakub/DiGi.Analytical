using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a material that possesses transparency characteristics, extending the base functionality of a solid material.
    /// </summary>
    public class TransparentMaterial : SolidMaterial
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransparentMaterial"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the transparent material.</param>
        public TransparentMaterial(string? name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransparentMaterial"/> class using an existing <see cref="TransparentMaterial"/> instance.
        /// </summary>
        /// <param name="transparentMaterial">The source <see cref="TransparentMaterial"/> instance to copy from.</param>
        public TransparentMaterial(TransparentMaterial? transparentMaterial)
            : base(transparentMaterial)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransparentMaterial"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the material properties. This value can be null.</param>
        public TransparentMaterial(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}