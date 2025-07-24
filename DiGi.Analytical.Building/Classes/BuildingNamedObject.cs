using DiGi.Analytical.Building.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public abstract class BuildingObject : Core.Parameter.Classes.ParametrizedGuidObject, IBuildingObject
    {
        public BuildingObject(BuildingObject buildingObject)
            : base(buildingObject)
        {

        }

        public BuildingObject(System.Guid guid, BuildingObject buildingObject)
            : base(guid, buildingObject)
        {

        }

        public BuildingObject()
            : base()
        {

        }

        public BuildingObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BuildingObject(System.Guid guid)
            : base(guid)
        {

        }
    }
}
