using System.Text.Json.Nodes;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a material with fluid-specific properties, extending the functionality of the base <see cref="Material"/> class.
    /// </summary>
    public class FluidMaterial : Material
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FluidMaterial"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the fluid material. This value can be null.</param>
        public FluidMaterial(string? name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluidMaterial"/> class using another <see cref="FluidMaterial"/> instance.
        /// </summary>
        /// <param name="fluidMaterial">The source <see cref="FluidMaterial"/> object to copy from.</param>
        public FluidMaterial(FluidMaterial? fluidMaterial)
            : base(fluidMaterial)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluidMaterial"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the material properties to initialize the instance.</param>
        public FluidMaterial(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}