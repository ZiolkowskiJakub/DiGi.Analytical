using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class BuildingNamedObject : BuildingObject, IBuildingNamedObject
    {
        public BuildingNamedObject(string name)
            : base()
        {
            Name = name;
        }

        public BuildingNamedObject(BuildingNamedObject buildingNamedObject)
            : base(buildingNamedObject)
        {
            if (buildingNamedObject != null)
            {
                Name = buildingNamedObject.Name;
            }
        }

        public BuildingNamedObject(System.Guid guid, BuildingNamedObject buildingNamedObject)
            : base(guid, buildingNamedObject)
        {
            if (buildingNamedObject != null)
            {
                Name = buildingNamedObject.Name;
            }
        }

        public BuildingNamedObject()
            : base()
        {

        }

        public BuildingNamedObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BuildingNamedObject(System.Guid guid, string name)
            : base(guid)
        {
            Name = name;
        }

        [JsonInclude, JsonPropertyName("Name")]
        public string Name { get; set; }
    }
}
