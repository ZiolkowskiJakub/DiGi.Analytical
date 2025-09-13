using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Classes
{
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
        private SurfaceValue? solarReflectance;

        [JsonInclude, JsonPropertyName("LightReflectance"), Description("Light Reflectance")]
        private SurfaceValue? lightReflectance;

        [JsonInclude, JsonPropertyName("Emissivity"), Description("Emissivity")]
        private SurfaceValue? emissivity;

        public OpaqueMaterial(string? name)
            : base(name)
        {

        }

        public OpaqueMaterial(OpaqueMaterial? opaqueMaterial)
            :base(opaqueMaterial)
        {
            if(opaqueMaterial is not null)
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

        public OpaqueMaterial(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

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
