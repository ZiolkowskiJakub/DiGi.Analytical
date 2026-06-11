using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
    /// <summary>
    /// Represents a material that is opaque, containing physical and thermal properties such as conductivity, density, and reflectance.
    /// </summary>
    public class OpaqueMaterial : SolidMaterial
    {
        [JsonInclude, JsonPropertyName("Conductivity"), Description("Conductivity")]
        private double conductivity;

        [JsonInclude, JsonPropertyName("Density"), Description("Density")]
        private double density;

        [JsonInclude, JsonPropertyName("SpecificHeat"), Description("Specific Heat")]
        private double specificHeat;

        [JsonInclude, JsonPropertyName("VapourDiffusionFactor"), Description("Vapour Diffusion Factor")]
        private double vapourDiffusionFactor;

        [JsonInclude, JsonPropertyName("SolarReflectance"), Description("Solar Reflectance")]
        private readonly SurfaceValue? solarReflectance;

        [JsonInclude, JsonPropertyName("LightReflectance"), Description("Light Reflectance")]
        private readonly SurfaceValue? lightReflectance;

        [JsonInclude, JsonPropertyName("Emissivity"), Description("Emissivity")]
        private SurfaceValue? emissivity;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpaqueMaterial"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the opaque material.</param>
        public OpaqueMaterial(string? name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpaqueMaterial"/> class by copying the properties from an existing <see cref="OpaqueMaterial"/> instance.
        /// </summary>
        /// <param name="opaqueMaterial">The source <see cref="OpaqueMaterial"/> instance to copy data from. This value can be null.</param>
        public OpaqueMaterial(OpaqueMaterial? opaqueMaterial)
            : base(opaqueMaterial)
        {
            if (opaqueMaterial is not null)
            {
                conductivity = opaqueMaterial.conductivity;
                specificHeat = opaqueMaterial.specificHeat;
                density = opaqueMaterial.density;
                vapourDiffusionFactor = opaqueMaterial.vapourDiffusionFactor;
                solarReflectance = Core.Query.Clone(opaqueMaterial.solarReflectance);
                lightReflectance = Core.Query.Clone(opaqueMaterial.lightReflectance);
                emissivity = Core.Query.Clone(opaqueMaterial.emissivity);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpaqueMaterial"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the material properties.</param>
        public OpaqueMaterial(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the thermal conductivity of the opaque material.
        /// </summary>
        [JsonIgnore]
        public double Conductivity
        {
            get
            {
                return conductivity;
            }

            set
            {
                conductivity = value;
            }
        }

        /// <summary>
        /// Gets or sets the density of the opaque material.
        /// </summary>
        [JsonIgnore]
        public double Density
        {
            get
            {
                return density;
            }

            set
            {
                density = value;
            }
        }

        /// <summary>
        /// Gets or sets the specific heat capacity of the opaque material.
        /// </summary>
        [JsonIgnore]
        public double SpecificHeat
        {
            get
            {
                return specificHeat;
            }

            set
            {
                specificHeat = value;
            }
        }

        /// <summary>
        /// Gets or sets the vapour diffusion factor of the opaque material.
        /// </summary>
        [JsonIgnore]
        public double VapourDiffusionFactor
        {
            get
            {
                return vapourDiffusionFactor;
            }

            set
            {
                vapourDiffusionFactor = value;
            }
        }

        /// <summary>
        /// Gets or sets the emissivity of the opaque material.
        /// </summary>
        [JsonIgnore]
        public SurfaceValue? Emissivity
        {
            get
            {
                return emissivity;
            }

            set
            {
                emissivity = value;
            }
        }
    }
}