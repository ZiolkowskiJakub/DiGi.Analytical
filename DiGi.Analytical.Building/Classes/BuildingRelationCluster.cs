using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingRelationCluster : ConstructionRelationCluster//UniqueObjectRelationCluster<IBuildingGuidObject, IBuildingRelation>, IBuildingObject
    {
        public BuildingRelationCluster()
            : base()
        {
        }

        public BuildingRelationCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public BuildingRelationCluster(BuildingRelationCluster? buildingRelationCluster)
            : base(buildingRelationCluster)
        {
        }

        public BuildingRelationCluster(IEnumerable<IBuildingGuidObject>? buildingUniqueObjects)
            : base(buildingUniqueObjects)
        {
        }

        public SpaceRelation? AddRelation(IComponent? component, ISpace? space_1, ISpace? space_2 = null)
        {
            if (component == null || space_1 == null)
            {
                return null;
            }

            SpaceRelation? spaceRelation = GetRelation<SpaceRelation>(new GuidReference(component));
            if (spaceRelation != null)
            {
                Remove(spaceRelation);
            }

            return AddRelation(new SpaceRelation(component, space_1, space_2));
        }

        public ZoneRelation? AddRelation(IZone? zone, IEnumerable<ISpace>? spaces)
        {
            if (zone == null || spaces == null)
            {
                return null;
            }

            ZoneRelation? zoneRelation = GetRelation<ZoneRelation>(new GuidReference(zone));
            if (zoneRelation != null)
            {
                Remove(zoneRelation);
            }

            return AddRelation(new ZoneRelation(zone, spaces));
        }

        public SpaceInternalConditionRelation? AddRelation(ISpace? space, IInternalCondition? internalCondition, HourRange? hourRange, string? id = null)
        {
            if (space == null || internalCondition == null)
            {
                return null;
            }

            //List<SpaceInternalConditionRelation> spaceInternalConditionRelations = GetRelations<SpaceInternalConditionRelation>(new GuidReference(space));
            //if (spaceInternalConditionRelations != null)
            //{
            //    Remove(spaceInternalConditionRelation);
            //}

            return AddRelation(new SpaceInternalConditionRelation(space, internalCondition, hourRange, id));
        }

        public PhysicalComponentConstructionRelation? AddRelation(IWall? wall, IWallConstruction? wallConstruction)
        {
            if (wall == null || wallConstruction == null)
            {
                return null;
            }

            PhysicalComponentConstructionRelation? physicalComponentConstructionRelation = GetRelation<PhysicalComponentConstructionRelation>(new GuidReference(wall));
            if (physicalComponentConstructionRelation != null)
            {
                Remove(physicalComponentConstructionRelation);
            }

            return AddRelation(new PhysicalComponentConstructionRelation(wall, wallConstruction));
        }

        public PhysicalComponentConstructionRelation? AddRelation(IRoof? roof, IRoofConstruction? roofConstruction)
        {
            if (roof == null || roofConstruction == null)
            {
                return null;
            }

            PhysicalComponentConstructionRelation? componentConstructionRelation = GetRelation<PhysicalComponentConstructionRelation>(new GuidReference(roof));
            if (componentConstructionRelation != null)
            {
                Remove(componentConstructionRelation);
            }

            return AddRelation(new PhysicalComponentConstructionRelation(roof, roofConstruction));
        }

        public PhysicalComponentConstructionRelation? AddRelation(IFloor? floor, IFloorConstruction? floorConstruction)
        {
            if (floor == null || floorConstruction == null)
            {
                return null;
            }

            PhysicalComponentConstructionRelation? physicalComponentConstructionRelation = GetRelation<PhysicalComponentConstructionRelation>(new GuidReference(floor));
            if (physicalComponentConstructionRelation != null)
            {
                Remove(physicalComponentConstructionRelation);
            }

            return AddRelation(new PhysicalComponentConstructionRelation(floor, floorConstruction));
        }

        public OpeningConstructionRelation? AddRelation(IWindow? window, IWindowConstruction? windowConstruction)
        {
            if (window == null || windowConstruction == null)
            {
                return null;
            }

            OpeningConstructionRelation? openingConstructionRelation = GetRelation<OpeningConstructionRelation>(new GuidReference(window));
            if (openingConstructionRelation != null)
            {
                Remove(openingConstructionRelation);
            }

            return AddRelation(new OpeningConstructionRelation(window, windowConstruction));
        }

        public OpeningConstructionRelation? AddRelation(IDoor? door, IDoorConstruction? doorConstruction)
        {
            if (door == null || doorConstruction == null)
            {
                return null;
            }

            OpeningConstructionRelation? openingConstructionRelation = GetRelation<OpeningConstructionRelation>(new GuidReference(door));
            if (openingConstructionRelation != null)
            {
                Remove(openingConstructionRelation);
            }

            return AddRelation(new OpeningConstructionRelation(door, doorConstruction));
        }

        public IComponent? GetComponent(SpaceRelation? spaceRelation)
        {
            if (spaceRelation?.UniqueReference_From is not GuidReference guidReference)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IComponent? result))
            {
                return null;
            }

            return result;
        }

        public IComponent? GetComponent(OpeningRelation? openingRelation)
        {
            if (openingRelation?.UniqueReference_From is not GuidReference guidReference)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IComponent? result))
            {
                return null;
            }

            return result;
        }

        public IPhysicalComponent? GetPhysicalComponent(PhysicalComponentConstructionRelation? physicalComponentConstructionRelation)
        {
            if (physicalComponentConstructionRelation?.UniqueReference_From is not GuidReference guidReference)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IPhysicalComponent? result))
            {
                return null;
            }

            return result;
        }

        public List<TComponent> GetComponents<TComponent>() where TComponent : IComponent
        {
            return GetValues<TComponent>();
        }

        public IPhysicalComponentConstruction? GetPhysicalComponentConstruction(PhysicalComponentConstructionRelation? physicalComponentConstructionRelation)
        {
            if (physicalComponentConstructionRelation?.UniqueReference_To is not GuidReference guidReference)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IPhysicalComponentConstruction? result))
            {
                return null;
            }

            return result;
        }

        public IInternalCondition? GetInternalCondition(SpaceInternalConditionRelation? spaceInternalConditionRelation)
        {
            if (spaceInternalConditionRelation?.UniqueReference_To is not GuidReference guidReference)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IInternalCondition? result))
            {
                return null;
            }

            return result;
        }

        public IOpening? GetOpening(OpeningConstructionRelation? openingConstructionRelation)
        {
            if (openingConstructionRelation?.UniqueReference_From is not GuidReference guidReference)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IOpening? result))
            {
                return null;
            }

            return result;
        }

        public IOpeningConstruction? GetOpeningConstruction(OpeningConstructionRelation? openingConstructionRelation)
        {
            if (openingConstructionRelation?.UniqueReference_To is not GuidReference guidReference)
            {
                return null;
            }

            if (!TryGetValue(guidReference, out IOpeningConstruction? result))
            {
                return null;
            }

            return result;
        }

        public List<IOpening>? GetOpenings(OpeningRelation? openingRelation)
        {
            List<IUniqueReference>? uniqueReferences = openingRelation?.UniqueReferences_To;
            if (uniqueReferences == null)
            {
                return null;
            }

            if (!TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<IOpening>? result))
            {
                return null;
            }

            return result;
        }
        
        public TSpace? GetSpace<TSpace>(SpaceInternalConditionRelation? spaceInternalConditionRelation) where TSpace : ISpace
        {
            if (spaceInternalConditionRelation?.UniqueReference_From is not GuidReference guidReference)
            {
                return default;
            }

            if (!TryGetValue(guidReference, out TSpace? result))
            {
                return default;
            }

            return result;
        }
        
        public List<ISpace>? GetSpaces(SpaceRelation? spaceRelation)
        {
            List<IUniqueReference>? uniqueReferences = spaceRelation?.UniqueReferences_To;
            if (uniqueReferences == null)
            {
                return null;
            }

            if (!TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<ISpace>? result))
            {
                return null;
            }

            return result;
        }

        public List<ISpace>? GetSpaces(ZoneRelation? zoneRelation)
        {
            List<IUniqueReference>? uniqueReferences = zoneRelation?.UniqueReferences_To;
            if (uniqueReferences == null)
            {
                return null;
            }

            if (!TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<ISpace>? result))
            {
                return null;
            }

            return result;
        }

        public List<TSpace>? GetSpaces<TSpace>() where TSpace : ISpace
        {
            return GetValues<TSpace>();
        }
    }
}
