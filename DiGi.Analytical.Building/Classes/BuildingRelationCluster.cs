using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a cluster of building relations, providing functionality to manage and organize relationships between building components.
    /// </summary>
    public class BuildingRelationCluster : ConstructionRelationCluster//UniqueObjectRelationCluster<IBuildingGuidObject, IBuildingRelation>, IBuildingObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingRelationCluster"/> class.
        /// </summary>
        public BuildingRelationCluster()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingRelationCluster"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to populate the properties of the building relation cluster.</param>
        public BuildingRelationCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingRelationCluster"/> class using an existing <see cref="BuildingRelationCluster"/> instance.
        /// </summary>
        /// <param name="buildingRelationCluster">The source <see cref="BuildingRelationCluster"/> instance to copy from.</param>
        public BuildingRelationCluster(BuildingRelationCluster? buildingRelationCluster)
            : base(buildingRelationCluster)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingRelationCluster"/> class using a collection of unique building objects.
        /// </summary>
        /// <param name="buildingUniqueObjects">The collection of unique building objects to initialize the cluster with. This value can be null.</param>
        public BuildingRelationCluster(IEnumerable<IBuildingGuidObject>? buildingUniqueObjects)
            : base(buildingUniqueObjects)
        {
        }

        /// <summary>
        /// Adds a spatial relation between a component and one or two spaces to the building relation cluster.
        /// </summary>
        /// <param name="component">The component that is part of the spatial relation.</param>
        /// <param name="space_1">The primary space associated with the relation.</param>
        /// <param name="space_2">An optional secondary space associated with the relation.</param>
        /// <returns>The newly created <see cref="SpaceRelation"/> object if successful; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Adds a relationship between a zone and a collection of spaces to the cluster, replacing any existing relation for the specified zone.
        /// </summary>
        /// <param name="zone">The zone object involved in the relation.</param>
        /// <param name="spaces">The collection of space objects associated with the zone.</param>
        /// <returns>The newly created <see cref="ZoneRelation"/> if successful; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Adds a relation between a space and an internal condition.
        /// </summary>
        /// <param name="space">The space associated with the internal condition.</param>
        /// <param name="internalCondition">The internal condition to be linked to the space.</param>
        /// <param name="hourRange">The optional hour range during which the internal condition applies.</param>
        /// <param name="id">An optional unique identifier for the relation.</param>
        /// <returns>The created <see cref="SpaceInternalConditionRelation"/> if successful; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Adds a relation between a wall and its corresponding wall construction.
        /// </summary>
        /// <param name="wall">The wall instance to be associated.</param>
        /// <param name="wallConstruction">The wall construction instance to be associated.</param>
        /// <returns>The created <see cref="PhysicalComponentConstructionRelation"/> if the relation was successfully added; otherwise, null.</returns>
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

        /// <summary>
        /// Adds a relation between a roof component and its corresponding construction definition, replacing any existing relation for the specified roof.
        /// </summary>
        /// <param name="roof">The roof object to be associated with a construction.</param>
        /// <param name="roofConstruction">The roof construction definition to associate with the roof.</param>
        /// <returns>The created <see cref="PhysicalComponentConstructionRelation"/> if successful; otherwise, null if either parameter is null.</returns>
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

        /// <summary>
        /// Adds a relation between a floor and its corresponding construction, replacing any existing relation for the specified floor.
        /// </summary>
        /// <param name="floor">The floor object to be associated with a construction.</param>
        /// <param name="floorConstruction">The construction definition to associate with the floor.</param>
        /// <returns>The newly created <see cref="PhysicalComponentConstructionRelation"/> if successful; otherwise, <c>null</c> if either parameter is null.</returns>
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

        /// <summary>
        /// Adds a relationship between the specified window and its corresponding window construction.
        /// </summary>
        /// <param name="window">The window object to be associated.</param>
        /// <param name="windowConstruction">The window construction object to be associated.</param>
        /// <returns>The created <see cref="OpeningConstructionRelation"/> if the relation was successfully added; otherwise, null.</returns>
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

        /// <summary>
        /// Adds a relation between a door and its construction, replacing any existing relation for the specified door.
        /// </summary>
        /// <param name="door">The door object to be related.</param>
        /// <param name="doorConstruction">The door construction object to be related.</param>
        /// <returns>The created <see cref="OpeningConstructionRelation"/> if successful; otherwise, null if either parameter is null.</returns>
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

        /// <summary>
        /// Retrieves the component associated with the specified space relation.
        /// </summary>
        /// <param name="spaceRelation">The space relation used to identify the component. This value can be <see langword="null"/>.</param>
        /// <returns>The <see cref="IComponent"/> associated with the provided space relation, or <see langword="null"/> if the relation is null, invalid, or no corresponding component is found.</returns>
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

        /// <summary>
        /// Retrieves the component associated with the specified opening relation.
        /// </summary>
        /// <param name="openingRelation">The opening relation used to identify the component.</param>
        /// <returns>The <see cref="IComponent"/> if a matching component is found; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Retrieves all components of the specified type from the cluster.
        /// </summary>
        /// <typeparam name="TComponent">The type of component to retrieve, which must implement <see cref="IComponent"/>.</typeparam>
        /// <returns>A list containing all components of type <typeparamref name="TComponent"/>.</returns>
        public List<TComponent> GetComponents<TComponent>() where TComponent : IComponent
        {
            return GetValues<TComponent>();
        }

        /// <summary>
        /// Retrieves the internal condition associated with the specified space internal condition relation.
        /// </summary>
        /// <param name="spaceInternalConditionRelation">The relation used to identify the internal condition.</param>
        /// <returns>The <see cref="IInternalCondition"/> if found; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Retrieves the opening associated with the specified opening construction relation.
        /// </summary>
        /// <param name="openingConstructionRelation">The opening construction relation used to look up the opening.</param>
        /// <returns>The <see cref="IOpening"/> if found; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Retrieves the opening construction associated with the specified opening construction relation.
        /// </summary>
        /// <param name="openingConstructionRelation">The opening construction relation used to identify the target opening construction.</param>
        /// <returns>The <see cref="IOpeningConstruction"/> if found; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Retrieves a list of opening objects associated with the specified opening relation.
        /// </summary>
        /// <param name="openingRelation">The opening relation containing references to the openings to be retrieved.</param>
        /// <returns>A list of <see cref="IOpening"/> objects if successfully retrieved; otherwise, null.</returns>
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

        /// <summary>
        /// Retrieves the physical component associated with the specified construction relation.
        /// </summary>
        /// <param name="physicalComponentConstructionRelation">The physical component construction relation used to identify the component.</param>
        /// <returns>The <see cref="IPhysicalComponent"/> if found; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Retrieves the physical component construction associated with the specified relation.
        /// </summary>
        /// <param name="physicalComponentConstructionRelation">The relation used to identify the physical component construction.</param>
        /// <returns>The matching <see cref="IPhysicalComponentConstruction"/> if found; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Retrieves a space of the specified type based on the provided internal condition relation.
        /// </summary>
        /// <typeparam name="TSpace">The type of space to retrieve, which must implement <see cref="ISpace"/>.</typeparam>
        /// <param name="spaceInternalConditionRelation">The internal condition relation used to identify the space via its reference.</param>
        /// <returns>The space object of type <typeparam ref="TSpace"/> if found; otherwise, the default value for the type.</returns>
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

        /// <summary>
        /// Retrieves a list of space objects associated with the specified space relation.
        /// </summary>
        /// <param name="spaceRelation">The space relation containing references to the spaces to be retrieved.</param>
        /// <returns>A list of <see cref="ISpace"/> objects if successfully retrieved; otherwise, null.</returns>
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

        /// <summary>
        /// Retrieves a list of space objects associated with the specified zone relation.
        /// </summary>
        /// <param name="zoneRelation">The zone relation object containing references to the spaces.</param>
        /// <returns>A list of <see cref="ISpace"/> objects if successfully retrieved; otherwise, null.</returns>
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

        /// <summary>
        /// Retrieves a list of space objects of the specified type from the cluster.
        /// </summary>
        /// <typeparam name="TSpace">The type of space object to retrieve, which must implement <see cref="ISpace"/>.</typeparam>
        /// <returns>A list containing the retrieved space objects of type <typeparam ref="TSpace"/>, or null if no such spaces are found.</returns>
        public List<TSpace>? GetSpaces<TSpace>() where TSpace : ISpace
        {
            return GetValues<TSpace>();
        }
    }
}