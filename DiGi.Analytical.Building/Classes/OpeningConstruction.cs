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
        private string description;

        [JsonInclude, JsonPropertyName("FrameStructure")]
        private IStructure frameStructure;

        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonInclude, JsonPropertyName("PaneStructure")]
        private IStructure paneStructure;
        
        public OpeningConstruction(string name, ISurface2D surface2D, IStructure structure)
            : base(surface2D)
        {
            this.name = name;
            paneStructure = Core.Query.Clone(structure);
            frameStructure = Core.Query.Clone(structure);
        }

        public OpeningConstruction(string name, ISurface2D surface2D, IStructure frameStructure, IStructure paneStructure)
            : base(surface2D)
        {
            this.name = name;
            this.frameStructure = Core.Query.Clone(frameStructure);
            this.paneStructure = Core.Query.Clone(paneStructure);
        }

        public OpeningConstruction(OpeningConstruction openingConstruction)
            : base(openingConstruction)
        {
            if (openingConstruction != null)
            {
                frameStructure = Core.Query.Clone(openingConstruction.frameStructure);
                paneStructure = Core.Query.Clone(openingConstruction.paneStructure);
            }
        }

        public OpeningConstruction(System.Guid guid, OpeningConstruction openingConstruction)
            : base(guid, openingConstruction)
        {
            if (openingConstruction != null)
            {
                frameStructure = Core.Query.Clone(openingConstruction.frameStructure);
                paneStructure = Core.Query.Clone(openingConstruction.paneStructure);
            }
        }

        public OpeningConstruction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public string Description
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
        public IStructure FrameStructure
        {
            get
            {
                return frameStructure;
            }

            set
            {
                frameStructure = value;
            }
        }

        [JsonIgnore]
        public string Name
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
        
        [JsonIgnore]
        public IStructure PaneStructure
        {
            get
            {
                return paneStructure;
            }

            set
            {
                paneStructure = value;
            }
        }
    }

    public abstract class OpeningConstruction<TConstructable> : OpeningConstruction, IOpeningConstruction<TConstructable> where TConstructable : IConstructable
    {
        public OpeningConstruction(string name, ISurface2D surface2D, IStructure structure)
            : base(name, surface2D, structure)
        {

        }

        public OpeningConstruction(string name, ISurface2D surface2D, IStructure frameStructure, IStructure paneStructure)
            : base(name, surface2D, frameStructure, paneStructure)
        {

        }

        public OpeningConstruction(OpeningConstruction openingConstruction)
            : base(openingConstruction)
        {

        }

        public OpeningConstruction(System.Guid guid, OpeningConstruction openingConstruction)
            : base(guid, openingConstruction)
        {

        }

        public OpeningConstruction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
