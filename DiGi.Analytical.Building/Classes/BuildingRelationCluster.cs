using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingRelationCluster : UniqueObjectRelationCluster<IBuildingGuidObject, IBuildingRelation>, IBuildingObject
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

        public BuildingRelationCluster(IEnumerable<IBuildingGuidObject> buildingUniqueObjects)
            : base(buildingUniqueObjects)
        {
        }

        public SpaceRelation AddRelation(IComponent component, ISpace space_1, ISpace space_2 = null)
        {
            if (component == null || space_1 == null)
            {
                return null;
            }

            SpaceRelation spaceRelation = GetRelation<SpaceRelation>(new GuidReference(component));
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

            ZoneRelation zoneRelation = GetRelation<ZoneRelation>(new GuidReference(zone));
            if (zoneRelation != null)
            {
                Remove(zoneRelation);
            }

            return AddRelation(new ZoneRelation(zone, spaces));
        }

        public ComponentConstructionRelation AddRelation(IWall wall, IWallConstruction wallConstruction)
        {
            return AddRelation(wall, wallConstruction);
        }

        public ComponentConstructionRelation AddRelation(IRoof roof, IRoofConstruction roofConstruction)
        {
            return AddRelation(roof, roofConstruction);
        }

        public ComponentConstructionRelation AddRelation(IFloor floor, IFloorConstruction floorConstruction)
        {
            return AddRelation(floor, floorConstruction);
        }

        public OpeningConstructionRelation AddRelation(IWindow window, IWindowConstruction windowConstruction)
        {
            return AddRelation(window, windowConstruction);
        }

        public OpeningConstructionRelation AddRelation(IDoor door, IDoorConstruction doorConstruction)
        {
            return AddRelation(door, doorConstruction);
        }

        public IComponent GetComponent(SpaceRelation spaceRelation)
        {
            GuidReference guidReference = spaceRelation?.UniqueReference_From as GuidReference;
            if (guidReference == null)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IComponent result))
            {
                return null;
            }

            return result;
        }

        public IComponent GetComponent(OpeningRelation openingRelation)
        {
            GuidReference guidReference = openingRelation?.UniqueReference_From as GuidReference;
            if (guidReference == null)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IComponent result))
            {
                return null;
            }

            return result;
        }

        public IComponent GetComponent(ComponentConstructionRelation componentConstructionRelation)
        {
            GuidReference guidReference = componentConstructionRelation?.UniqueReference_From as GuidReference;
            if (guidReference == null)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IComponent result))
            {
                return null;
            }

            return result;
        }

        public List<TComponent> GetComponents<TComponent>() where TComponent : IComponent
        {
            return GetValues<TComponent>();
        }
        
        public IConstruction GetConstruction(ComponentConstructionRelation componentConstructionRelation)
        {
            GuidReference guidReference = componentConstructionRelation?.UniqueReference_To as GuidReference;
            if (guidReference == null)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IConstruction result))
            {
                return null;
            }

            return result;
        }

        public IOpening GetOpening(OpeningConstructionRelation openingConstructionRelation)
        {
            GuidReference guidReference = openingConstructionRelation?.UniqueReference_From as GuidReference;
            if (guidReference == null)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IOpening result))
            {
                return null;
            }

            return result;
        }

        public IOpeningConstruction GetOpeningConstruction(OpeningConstructionRelation openingConstructionRelation)
        {
            GuidReference guidReference = openingConstructionRelation?.UniqueReference_To as GuidReference;
            if (guidReference == null)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IOpeningConstruction result))
            {
                return null;
            }

            return result;
        }

        public List<IOpening> GetOpenings(OpeningRelation openingRelation)
        {
            List<IUniqueReference> uniqueReferences = openingRelation?.UniqueReferences_To;
            if (uniqueReferences == null)
            {
                return null;
            }

            if (!TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<IOpening> result))
            {
                return null;
            }

            return result;
        }

        public List<ISpace> GetSpaces(SpaceRelation spaceRelation)
        {
            List<IUniqueReference> uniqueReferences = spaceRelation?.UniqueReferences_To;
            if (uniqueReferences == null)
            {
                return null;
            }

            if (!TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<ISpace> result))
            {
                return null;
            }

            return result;
        }

        public List<ISpace> GetSpaces(ZoneRelation zoneRelation)
        {
            List<IUniqueReference> uniqueReferences = zoneRelation?.UniqueReferences_To;
            if (uniqueReferences == null)
            {
                return null;
            }

            if (!TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<ISpace> result))
            {
                return null;
            }

            return result;
        }

        public List<TSpace> GetSpaces<TSpace>() where TSpace : ISpace
        {
            return GetValues<TSpace>();
        }

        private ComponentConstructionRelation AddRelation(IComponent component, IComponentConstruction componentConstruction)
        {
            if (component == null || componentConstruction == null)
            {
                return null;
            }

            ComponentConstructionRelation componentConstructionRelation = GetRelation<ComponentConstructionRelation>(new GuidReference(component));
            if (componentConstructionRelation != null)
            {
                Remove(componentConstructionRelation);
            }

            return AddRelation(new ComponentConstructionRelation(component, componentConstruction));
        }

        private OpeningConstructionRelation AddRelation(IOpening opening, IOpeningConstruction openingConstruction)
        {
            if (opening == null || openingConstruction == null)
            {
                return null;
            }

            OpeningConstructionRelation openingConstructionRelation = GetRelation<OpeningConstructionRelation>(new GuidReference(opening));
            if (openingConstructionRelation != null)
            {
                Remove(openingConstructionRelation);
            }

            return AddRelation(new OpeningConstructionRelation(opening, openingConstruction));
        }
    }
}
