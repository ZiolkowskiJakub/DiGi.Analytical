using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class OpeningConstruction : BuildingGeometry2DObject<ISurface2D>, IOpeningConstruction
    {
        [JsonInclude, JsonPropertyName("Description"), Description("Description")]
        private string? description;

        [JsonInclude, JsonPropertyName("Name")]
        private string? name;

        public OpeningConstruction(string? name, ISurface2D? surface2D)
            : base(surface2D)
        {
            this.name = name;
        }

        public OpeningConstruction(OpeningConstruction? openingConstruction)
            : base(openingConstruction)
        {
            if (openingConstruction != null)
            {
            }
        }

        public OpeningConstruction(System.Guid guid, OpeningConstruction? openingConstruction)
            : base(guid, openingConstruction)
        {
            if (openingConstruction != null)
            {
            }
        }

        public OpeningConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public string? Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }

    public abstract class OpeningConstruction<TOpening> : OpeningConstruction, IOpeningConstruction<TOpening> where TOpening : IOpening
    {
        public OpeningConstruction(string? name, ISurface2D? surface2D)
            : base(name, surface2D)
        {
        }

        public OpeningConstruction(OpeningConstruction? openingConstruction)
            : base(openingConstruction)
        {
        }

        public OpeningConstruction(System.Guid guid, OpeningConstruction? openingConstruction)
            : base(guid, openingConstruction)
        {
        }

        public OpeningConstruction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}