using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.Text.Json.Serialization;
using DiGi.Core;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingModel : UniqueParametrizedObject, IBuildingUniqueObject, IModel
    {
        [JsonInclude, JsonPropertyName("BuildingRelationCluster"), System.ComponentModel.Description("BuildingRelationCluster")]
        private BuildingRelationCluster buildingRelationCluster = new BuildingRelationCluster();

        public bool Add(IComponent component)
        {
            if(component == null)
            {
                return false;
            }

            return buildingRelationCluster.Update(component.Clone<IComponent>());
        }

        public bool Add(IConstruction construction)
        {
            if (construction == null)
            {
                return false;
            }

            return buildingRelationCluster.Update(construction.Clone<IConstruction>());
        }

        private bool Assign(IWall wall, IWallConstruction wallConstruction)
        {
            if (wall == null || wallConstruction == null)
            {
                return false;
            }

            if(!buildingRelationCluster.Update(wall))
            {
                return false;
            }


            if(!buildingRelationCluster.Update(wallConstruction))
            {
                return false;
            }

            return buildingRelationCluster.AddRelation(wall, wallConstruction) != null;
        }
    }
}
