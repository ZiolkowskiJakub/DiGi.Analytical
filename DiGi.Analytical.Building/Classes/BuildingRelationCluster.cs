using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingRelationCluster : UniqueObjectRelationCluster<IBuildingUniqueObject, IBuildingRelation>, IBuildingObject
    {
        public BuildingRelationCluster()
            : base()
        {
        }

        public BuildingRelationCluster(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public BuildingRelationCluster(BuildingRelationCluster buildingCluster)
            : base(buildingCluster)
        {
        }

        public BuildingRelationCluster(IEnumerable<IBuildingUniqueObject> buildingUniqueObjects)
            : base(buildingUniqueObjects)
        {
        }

        public SpaceRelation AddRelation(IComponent component, ISpace space_1, ISpace space_2 = null)
        {
            if (component == null || space_1 == null)
            {
                return null;
            }

            SpaceRelation spaceRelation = GetRelation<SpaceRelation>(new UniqueReference(component));
            if (spaceRelation != null)
            {
                Remove(spaceRelation);
            }

            return AddRelation(new SpaceRelation(component, space_1, space_2));
        }

        public ZoneRelation AddRelation(IZone zone, IEnumerable<ISpace> spaces)
        {
            if (zone == null || spaces == null)
            {
                return null;
            }

            ZoneRelation zoneRelation = GetRelation<ZoneRelation>(new UniqueReference(zone));
            if (zoneRelation != null)
            {
                Remove(zoneRelation);
            }

            return AddRelation(new ZoneRelation(zone, spaces));
        }

        public ComponentConstructionRelation AddRelation(IWall wall, IWallConstruction wallConstruction)
        {
            return AddRelation(new ComponentConstructionRelation(wall, wallConstruction));
        }

        public ComponentConstructionRelation AddRelation(IRoof roof, IRoofConstruction roofConstruction)
        {
            return AddRelation(new ComponentConstructionRelation(roof, roofConstruction));
        }

        public ComponentConstructionRelation AddRelation(IFloor floor, IFloorConstruction floorConstruction)
        {
            return AddRelation(new ComponentConstructionRelation(floor, floorConstruction));
        }

        private ComponentConstructionRelation AddRelation(IComponent component, IComponentConstruction componentConstruction)
        {
            if (component == null || componentConstruction == null)
            {
                return null;
            }

            ComponentConstructionRelation componentConstructionRelation = GetRelation<ComponentConstructionRelation>(new UniqueReference(component));
            if (componentConstructionRelation != null)
            {
                Remove(componentConstructionRelation);
            }

            return AddRelation(new ComponentConstructionRelation(component, componentConstruction));
        }

        public List<Space> GetSpaces(SpaceRelation spaceRelation)
        {
            List<UniqueReference> uniqueReferences = spaceRelation?.UniqueReferences_To;
            if(uniqueReferences == null)
            {
                return null;
            }

            if(!TryGetObjects(uniqueReferences, out List<Space> result))
            {
                return null;
            }

            return result;
        }

        public IComponent GetComponent(SpaceRelation spaceRelation)
        {
            UniqueReference uniqueReference = spaceRelation?.UniqueReference_From;
            if (uniqueReference == null)
            {
                return null;
            }

            if (!TryGetObject(uniqueReference, out IComponent result))
            {
                return null;
            }

            return result;
        }

        public IComponent GetComponent(ComponentConstructionRelation componentConstructionRelation)
        {
            UniqueReference uniqueReference = componentConstructionRelation?.UniqueReference_From;
            if (uniqueReference == null)
            {
                return null;
            }

            if (!TryGetObject(uniqueReference, out IComponent result))
            {
                return null;
            }

            return result;
        }

        public IConstruction GetConstruction(ComponentConstructionRelation componentConstructionRelation)
        {
            UniqueReference uniqueReference = componentConstructionRelation?.UniqueReference_To;
            if (uniqueReference == null)
            {
                return null;
            }

            if (!TryGetObject(uniqueReference, out IConstruction result))
            {
                return null;
            }

            return result;
        }
    }
}
