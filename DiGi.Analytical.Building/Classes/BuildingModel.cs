using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using DiGi.Core.Relation.Enums;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents an analytical building model that manages structural relations, building information, and spatial bounding properties.
    /// </summary>
    public class BuildingModel : ParametrizedGuidObject, IBuildingGuidObject, IGuidModel, IBuildingBoundable3D
    {
        [JsonInclude, JsonPropertyName("BuildingRelationCluster"), System.ComponentModel.Description("BuildingRelationCluster")]
        private readonly BuildingRelationCluster buildingRelationCluster = [];

        [JsonInclude, JsonPropertyName("BuildingInformation"), System.ComponentModel.Description("BuildingInformation")]
        private BuildingInformation buildingInformation = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModel"/> class.
        /// </summary>
        public BuildingModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModel"/> class by cloning an existing building model.
        /// </summary>
        /// <param name="buildingModel">The source <see cref="BuildingModel"/> instance to copy data from. If null, a default instance is initialized.</param>
        public BuildingModel(BuildingModel? buildingModel)
            : base(buildingModel)
        {
            if (buildingModel != null)
            {
                buildingRelationCluster = Core.Query.Clone(buildingModel.buildingRelationCluster) ?? [];
                buildingInformation = Core.Query.Clone(buildingModel.buildingInformation) ?? new();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModel"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the building model data, or <see langword="null"/> if no data is provided.</param>
        public BuildingModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the building information associated with this building model.
        /// </summary>
        [JsonIgnore]
        public BuildingInformation BuildingInformation
        {
            get
            {
                return buildingInformation;
            }

            set
            {
                if (value is null)
                {
                    return;
                }

                buildingInformation = value;
            }
        }

        /// <summary>
        /// Assigns a wall to its corresponding wall construction within the building model.
        /// </summary>
        /// <param name="wall">The wall object to be assigned.</param>
        /// <param name="wallConstruction">The wall construction object to be associated with the wall.</param>
        /// <returns>True if the assignment was successful; otherwise, false.</returns>
        public bool Assign(IWall? wall, IWallConstruction? wallConstruction)
        {
            if (wall == null || wallConstruction == null)
            {
                return false;
            }

            if (!Update(wall))
            {
                return false;
            }

            if (!Update(wallConstruction))
            {
                return false;
            }

            return buildingRelationCluster.AddRelation(wall, wallConstruction) != null;
        }

        /// <summary>
        /// Assigns a relationship between the specified roof and its corresponding roof construction within the building model.
        /// </summary>
        /// <param name="roof">The roof object to be assigned. This value can be null.</param>
        /// <param name="roofConstruction">The roof construction object to be assigned. This value can be null.</param>
        /// <returns>True if the assignment was successful and the relation was created; otherwise, false.</returns>
        public bool Assign(IRoof? roof, IRoofConstruction? roofConstruction)
        {
            if (roof == null || roofConstruction == null)
            {
                return false;
            }

            if (!Update(roof))
            {
                return false;
            }

            if (!Update(roofConstruction))
            {
                return false;
            }

            return buildingRelationCluster.AddRelation(roof, roofConstruction) != null;
        }

        /// <summary>
        /// Assigns a floor construction to a specific floor within the building model.
        /// </summary>
        /// <param name="floor">The floor object to be assigned.</param>
        /// <param name="floorConstruction">The floor construction object to be assigned.</param>
        /// <returns>True if the assignment was successful; otherwise, false.</returns>
        public bool Assign(IFloor? floor, IFloorConstruction? floorConstruction)
        {
            if (floor == null || floorConstruction == null)
            {
                return false;
            }

            if (!Update(floor))
            {
                return false;
            }

            if (!Update(floorConstruction))
            {
                return false;
            }

            return buildingRelationCluster.AddRelation(floor, floorConstruction) != null;
        }

        /// <summary>
        /// Assigns a window construction to the specified window within the building model.
        /// </summary>
        /// <param name="window">The window instance to which the construction is assigned. May be null.</param>
        /// <param name="windowConstruction">The window construction instance to assign. May be null.</param>
        /// <returns>True if the assignment was successfully created; otherwise, false.</returns>
        public bool Assign(IWindow? window, IWindowConstruction? windowConstruction)
        {
            if (window == null || windowConstruction == null)
            {
                return false;
            }

            if (!Update(window))
            {
                return false;
            }

            if (!Update(windowConstruction))
            {
                return false;
            }

            return buildingRelationCluster.AddRelation(window, windowConstruction) != null;
        }

        /// <summary>
        /// Assigns a relationship between the specified door and its corresponding door construction within the building model.
        /// </summary>
        /// <param name="door">The door object to be assigned. This value can be null.</param>
        /// <param name="doorConstruction">The door construction object to be assigned. This value can be null.</param>
        /// <returns>True if the relationship was successfully established; otherwise, false.</returns>
        public bool Assign(IDoor? door, IDoorConstruction? doorConstruction)
        {
            if (door == null || doorConstruction == null)
            {
                return false;
            }

            if (!Update(door))
            {
                return false;
            }

            if (!Update(doorConstruction))
            {
                return false;
            }

            return buildingRelationCluster.AddRelation(door, doorConstruction) != null;
        }

        /// <summary>
        /// Assigns a component to one or two spaces and establishes the corresponding relationship within the building model.
        /// <para>The relation REPLACES any existing space assignment of the component, it is not added to it. Pass both spaces in one call to have a component bound by two spaces, and pass the component and its spaces through <see cref="Update(IComponent)"/> beforehand only if their other data changed - this method already stores all of them.</para>
        /// </summary>
        /// <param name="component">The component to be assigned.</param>
        /// <param name="space_1">The primary space associated with the component.</param>
        /// <param name="space_2">An optional secondary space associated with the component.</param>
        /// <returns>True if the component and spaces were successfully updated and the relationship was created; otherwise, false.</returns>
        /// <seealso cref="Unassign(IComponent, ISpace)"/>
        public bool Assign(IComponent? component, ISpace? space_1, ISpace? space_2 = null)
        {
            if (component == null || space_1 == null)
            {
                return false;
            }

            if (!Update(component))
            {
                return false;
            }

            if (!Update(space_1))
            {
                return false;
            }

            if (space_2 != null)
            {
                if (!Update(space_2))
                {
                    return false;
                }
            }

            return buildingRelationCluster.AddRelation(component, space_1, space_2) != null;
        }

        /// <summary>
        /// Assigns a collection of spaces to a specified zone within the building model.
        /// </summary>
        /// <param name="zone">The zone to which the spaces should be assigned. May be null.</param>
        /// <param name="spaces">The collection of spaces to associate with the zone. May be null.</param>
        /// <returns>True if the assignment was successful and the relation was created; otherwise, false.</returns>
        public bool Assign(IZone? zone, IEnumerable<ISpace>? spaces)
        {
            if (zone == null || spaces == null)
            {
                return false;
            }

            if (!Update(zone))
            {
                return false;
            }

            List<ISpace> spaces_Temp = [];
            foreach (ISpace space in spaces)
            {
                if (Update(space))
                {
                    spaces_Temp.Add(space);
                }
            }

            return buildingRelationCluster.AddRelation(zone, spaces_Temp) != null;
        }

        /// <summary>
        /// Assigns an internal condition to a specific space within the building model.
        /// </summary>
        /// <param name="space">The space object to which the internal condition is assigned.</param>
        /// <param name="internalCondition">The internal condition object to be assigned to the space.</param>
        /// <param name="hourRange">An optional hour range specifying when the internal condition applies.</param>
        /// <param name="id">An optional unique identifier for the assignment relation.</param>
        /// <returns>True if the internal condition was successfully assigned to the space; otherwise, false.</returns>
        public bool Assign(ISpace? space, IInternalCondition? internalCondition, HourRange? hourRange, string? id = null)
        {
            if (space == null || internalCondition == null)
            {
                return false;
            }

            if (!Update(internalCondition))
            {
                return false;
            }

            if (!Update(space))
            {
                return false;
            }

            return buildingRelationCluster.AddRelation(space, internalCondition, hourRange, id) != null;
        }

        /// <summary>
        /// Assigns a collection of spaces to an internal condition with an optional time range and identifier.
        /// </summary>
        /// <typeparam name="TSpace">The type of the space objects, which must implement <see cref="ISpace"/>.</typeparam>
        /// <param name="spaces">A collection of spaces to be assigned.</param>
        /// <param name="internalCondition">The internal condition to associate with the spaces.</param>
        /// <param name="hourRange">An optional time range during which the assignment is valid.</param>
        /// <param name="id">An optional unique identifier for the relation.</param>
        /// <returns><c>true</c> if at least one space was successfully assigned; otherwise, <c>false</c>.</returns>
        public bool Assign<TSpace>(IEnumerable<TSpace>? spaces, IInternalCondition? internalCondition, HourRange? hourRange, string? id = null) where TSpace : ISpace
        {
            if (internalCondition == null || spaces == null)
            {
                return false;
            }

            bool result = false;
            foreach (TSpace space in spaces)
            {
                if (Assign(space, internalCondition, hourRange, id))
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the building model.
        /// </summary>
        /// <returns>The bounding box encompassing all components in the building model, or <see langword="null"/> if it cannot be created.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            List<IComponent> components = buildingRelationCluster.GetComponents<IComponent>();
            if (components == null || components.Count == 0)
            {
                return null;
            }

            List<BoundingBox3D> boundingBox3Ds = [];
            foreach (IComponent component in components)
            {
                if (component.GetBoundingBox() is not BoundingBox3D boundingBox3D)
                {
                    continue;
                }

                boundingBox3Ds.Add(boundingBox3D);
            }

            if (boundingBox3Ds is null || boundingBox3Ds.Count == 0)
            {
                return null;
            }

            return Geometry.Spatial.Create.BoundingBox3D(boundingBox3Ds);
        }

        /// <summary>
        /// Retrieves a component of the specified type associated with the given opening.
        /// </summary>
        /// <typeparam name="TComponent">The type of the component to retrieve, which must implement <see cref="IComponent"/>.</typeparam>
        /// <param name="opening">The opening for which the associated component is being retrieved. May be <c>null</c>.</param>
        /// <returns>A cloned instance of the requested component type if found and compatible; otherwise, <c>null</c>.</returns>
        public TComponent? GetComponent<TComponent>(IOpening? opening) where TComponent : IComponent
        {
            if (opening == null)
            {
                return default;
            }

            OpeningRelation? openingRelation = GetRelation<OpeningRelation>(opening);
            if (opening == null)
            {
                return default;
            }

            IComponent? component = buildingRelationCluster?.GetComponent(openingRelation);
            if (component == null)
            {
                return default;
            }

            if (component is TComponent component_Temp)
            {
                return component_Temp.Clone<TComponent>();
            }

            return default;
        }

        /// <summary>
        /// Retrieves a list of components of the specified type associated with the given physical component construction.
        /// </summary>
        /// <typeparam name="TComponent">The type of components to retrieve, which must implement <see cref="IComponent"/>.</typeparam>
        /// <param name="physicalComponentConstruction">The physical component construction used to identify related components.</param>
        /// <returns>A list of components of type <typeparamref name="TComponent"/> if found; otherwise, <see langword="null"/>.</returns>
        public List<TComponent>? GetComponents<TComponent>(IPhysicalComponentConstruction? physicalComponentConstruction) where TComponent : IComponent
        {
            if (buildingRelationCluster == null || physicalComponentConstruction == null)
            {
                return null;
            }

            List<PhysicalComponentConstructionRelation>? physicalComponentConstructionRelations = GetRelations<PhysicalComponentConstructionRelation>(physicalComponentConstruction);
            if (physicalComponentConstructionRelations == null)
            {
                return default;
            }

            List<TComponent> result = [];
            foreach (PhysicalComponentConstructionRelation physicalConstructionRelation in physicalComponentConstructionRelations)
            {
                IComponent? component = buildingRelationCluster.GetPhysicalComponent(physicalConstructionRelation);
                if (component is TComponent component_Temp)
                {
                    result.Add(component_Temp);
                }
            }

            return result.CloneAndFilterNulls();
        }

        /// <summary>Retrieves a list of components of the specified type associated with the given space.</summary>
        /// <typeparam name="TComponent">The type of component to retrieve, which must implement <see cref="IComponent"/>.</typeparam>
        /// <param name="space">The space for which to retrieve the associated components. May be null.</param>
        /// <returns>A list of CLONED components of type <typeparamref name="TComponent"/> if successful; otherwise, null. Modifying them does not affect the model, pass them through <see cref="Update(IComponent)"/> to store the changes.</returns>
        public List<TComponent>? GetComponents<TComponent>(ISpace? space) where TComponent : IComponent
        {
            if (buildingRelationCluster == null || space == null)
            {
                return null;
            }

            List<SpaceRelation>? spaceRelations = GetRelations<SpaceRelation>(space);
            if (spaceRelations == null)
            {
                return default;
            }

            List<TComponent> result = [];
            foreach (SpaceRelation spaceRelation in spaceRelations)
            {
                IComponent? component = buildingRelationCluster.GetComponent(spaceRelation);
                if (component is TComponent component_Temp)
                {
                    result.Add(component_Temp);
                }
            }

            return result.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves a list of components of the specified type that define the relationship between two spaces.
        /// </summary>
        /// <typeparam name="TComponent">The type of component to retrieve, which must implement <see cref="IComponent"/>.</typeparam>
        /// <param name="space_1">The first space involved in the relation.</param>
        /// <param name="space_2">The second space involved in the relation.</param>
        /// <returns>A list of components of type <typeparamref name="TComponent"/> if successful; otherwise, <see langword="null"/>.</returns>
        public List<TComponent>? GetComponents<TComponent>(ISpace? space_1, ISpace? space_2) where TComponent : IComponent
        {
            if (buildingRelationCluster == null || space_1 == null || space_2 == null)
            {
                return null;
            }

            GuidReference guidReference = new(space_2);

            List<SpaceRelation>? spaceRelations = GetRelations(space_1, (SpaceRelation? x) => x?.UniqueReferences_To is not null && x.UniqueReferences_To.Contains(guidReference));
            if (spaceRelations == null)
            {
                return default;
            }

            List<TComponent> result = [];
            foreach (SpaceRelation spaceRelation in spaceRelations)
            {
                IComponent? component = buildingRelationCluster.GetComponent(spaceRelation);
                if (component is TComponent component_Temp)
                {
                    result.Add(component_Temp);
                }
            }

            return result.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves all components of the specified type from the building relation cluster.
        /// </summary>
        /// <typeparam name="TComponent">The type of component to retrieve, which must implement <see cref="IComponent"/>.</typeparam>
        /// <returns>A list of components of type <typeparamref name="TComponent"/>, or null if no such components are found.</returns>
        public List<TComponent>? GetComponents<TComponent>() where TComponent : IComponent
        {
            return buildingRelationCluster.GetComponents<TComponent>().CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves the door construction associated with the specified door.
        /// </summary>
        /// <param name="door">The door for which to retrieve the construction.</param>
        /// <returns>The <see cref="IDoorConstruction"/> associated with the provided door, or <c>null</c> if no such construction is found or if the door is null.</returns>
        public IDoorConstruction? GetDoorConstruction(IDoor? door)
        {
            return GetOpeningConstruction<IDoorConstruction>(door);
        }

        /// <summary>
        /// Retrieves the floor construction associated with the specified floor.
        /// <para>The construction is the one established by <see cref="Assign(IFloor, IFloorConstruction)"/> for the identifier of the given floor, which is why a component rebuilt under the same identifier keeps its construction.</para>
        /// </summary>
        /// <param name="floor">The floor for which to retrieve the construction.</param>
        /// <returns>A CLONE of the <see cref="IFloorConstruction"/> associated with the provided floor, or <c>null</c> if no such construction exists or the floor is null.</returns>
        public IFloorConstruction? GetFloorConstruction(IFloor? floor)
        {
            return GetPhysicalComponentConstruction<IFloorConstruction>(floor);
        }

        /// <summary>
        /// Retrieves the internal conditions associated with the specified space.
        /// </summary>
        /// <typeparam name="TInternalCondition">The type of internal condition to retrieve, which must implement <see cref="IInternalCondition"/>.</typeparam>
        /// <param name="space">The space for which to retrieve the internal conditions.</param>
        /// <returns>A list of internal conditions of type <typeparamref name="TInternalCondition"/> associated with the specified space, or null if no such conditions are found or if the input is null.</returns>
        public List<TInternalCondition>? GetInternalConditions<TInternalCondition>(ISpace? space) where TInternalCondition : IInternalCondition
        {
            if (buildingRelationCluster == null || space == null)
            {
                return default;
            }

            List<SpaceInternalConditionRelation>? spaceInternalConditionRelations = GetRelations<SpaceInternalConditionRelation>(space);
            if (spaceInternalConditionRelations == null)
            {
                return default;
            }

            List<TInternalCondition> result = [];
            foreach (SpaceInternalConditionRelation spaceInternalConditionRelation in spaceInternalConditionRelations)
            {
                IInternalCondition? internalCondition = buildingRelationCluster.GetInternalCondition(spaceInternalConditionRelation);
                if (internalCondition is TInternalCondition internalCondition_Temp)
                {
                    TInternalCondition? internalCondition_Temp_Temp = internalCondition_Temp.Clone<TInternalCondition>();
                    if (internalCondition_Temp_Temp != null)
                    {
                        result.Add(internalCondition_Temp_Temp);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves an object of type <typeparamref name="TBuildingGuidObject"/> using the specified GUID reference.
        /// </summary>
        /// <typeparam name="TBuildingGuidObject">The type of the building GUID object to retrieve, which must implement <see cref="IBuildingGuidObject"/>.</typeparam>
        /// <param name="guidReference">The GUID reference of the object to retrieve.</param>
        /// <returns>The retrieved object of type <typeparamref name="TBuildingGuidObject"/> if found; otherwise, <see langword="null"/>.</returns>
        public TBuildingGuidObject? GetObject<TBuildingGuidObject>(GuidReference? guidReference) where TBuildingGuidObject : IBuildingGuidObject
        {
            if (TryGetObject(guidReference, out TBuildingGuidObject? result))
            {
                return result;
            }

            return default;
        }

        /// <summary>
        /// Retrieves a building object associated with the specified building relation.
        /// </summary>
        /// <typeparam name="TBuildingGuidObject">The type of the building GUID object to retrieve.</typeparam>
        /// <param name="buildingRelation">The building relation used to identify the target object.</param>
        /// <returns>The retrieved and cloned building object if found; otherwise, <see langword="null"/>.</returns>
        public TBuildingGuidObject? GetObject<TBuildingGuidObject>(IBuildingRelation? buildingRelation) where TBuildingGuidObject : IBuildingGuidObject
        {
            if (buildingRelation == null || buildingRelationCluster == null)
            {
                return default;
            }

            List<IUniqueReference>? uniqueReferences = buildingRelation?.UniqueReferences;
            if (uniqueReferences == null)
            {
                return default;
            }

            foreach (IUniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is not GuidReference guidReference)
                {
                    continue;
                }

                if (!buildingRelationCluster.TryGetValue(guidReference, out TBuildingGuidObject? result))
                {
                    return result.Clone<TBuildingGuidObject>();
                }
            }

            return default;
        }

        /// <summary>Retrieves a list of building objects associated with the specified building relation.</summary>
        /// <typeparam name="TBuildingGuidObject">The type of building GUID object to retrieve, which must implement <see cref="IBuildingGuidObject"/>.</typeparam>
        /// <param name="buildingRelation">The building relation used to identify the associated objects. Can be null.</param>
        /// <returns>A list of objects of type <typeparamref name="TBuildingGuidObject"/> if found; otherwise, null.</returns>
        public List<TBuildingGuidObject>? GetObjects<TBuildingGuidObject>(IBuildingRelation? buildingRelation) where TBuildingGuidObject : IBuildingGuidObject
        {
            if (buildingRelation == null || buildingRelationCluster == null)
            {
                return null;
            }

            List<IUniqueReference>? uniqueReferences = buildingRelation?.UniqueReferences;
            if (uniqueReferences == null)
            {
                return null;
            }

            if (!buildingRelationCluster.TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<TBuildingGuidObject>? result))
            {
                return null;
            }

            return result.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves a list of opening objects associated with the specified component.
        /// </summary>
        /// <typeparam name="TOpening">The type of opening object to retrieve, which must implement <see cref="IOpening"/>.</typeparam>
        /// <param name="component">The component for which associated openings are retrieved.</param>
        /// <returns>A list of objects of type <typeparam ref="TOpening"/> if associations are found; otherwise, <see langword="null"/>.</returns>
        public List<TOpening>? GetOpenings<TOpening>(IComponent? component) where TOpening : IOpening
        {
            if (buildingRelationCluster == null || component == null)
            {
                return null;
            }

            OpeningRelation? openingRelation = GetRelation<OpeningRelation>(component);
            if (openingRelation == null)
            {
                return null;
            }

            List<IUniqueReference>? uniqueReferences = openingRelation.UniqueReferences_To;
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                return null;
            }

            if (!buildingRelationCluster.TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<TOpening>? result))
            {
                return null;
            }

            return result;
        }

        /// <summary>Retrieves a list of openings that match the specified criteria.</summary>
        /// <typeparam name="TOpening">The type of opening to retrieve, which must implement <see cref="IOpening"/>.</typeparam>
        /// <param name="func">An optional predicate used to filter the retrieved openings.</param>
        /// <returns>A list of openings matching the criteria, or null if the building relation cluster is not available.</returns>
        public List<TOpening>? GetOpenings<TOpening>(Func<TOpening?, bool>? func = null) where TOpening : IOpening
        {
            if (buildingRelationCluster == null)
            {
                return null;
            }

            return buildingRelationCluster?.GetValues(func)?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves a list of openings associated with the specified opening construction.
        /// </summary>
        /// <typeparam name="TOpening">The type of opening to retrieve, which must implement <see cref="IOpening"/>.</typeparam>
        /// <param name="openingConstruction">The opening construction object used to find related openings. Can be null.</param>
        /// <returns>A list of openings of type <typeparam ref="TOpening"/> associated with the provided construction, or null if no such openings are found or if inputs are null.</returns>
        public List<TOpening>? GetOpenings<TOpening>(IOpeningConstruction? openingConstruction) where TOpening : IOpening
        {
            if (buildingRelationCluster == null || openingConstruction == null)
            {
                return null;
            }

            List<OpeningConstructionRelation>? openingConstructionRelations = GetRelations<OpeningConstructionRelation>(openingConstruction);
            if (openingConstructionRelations == null)
            {
                return default;
            }

            List<TOpening> result = [];
            foreach (OpeningConstructionRelation openingConstructionRelation in openingConstructionRelations)
            {
                IOpening? opening = buildingRelationCluster.GetOpening(openingConstructionRelation);
                if (opening is TOpening opening_Temp)
                {
                    result.Add(opening_Temp);
                }
            }

            return result.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves a specific building relation associated with the provided unique object.
        /// </summary>
        /// <typeparam name="TBuildingRelation">The type of the building relation to retrieve, which must implement <see cref="IBuildingRelation"/>.</typeparam>
        /// <param name="buildingUniqueObject">The building unique object for which the relation is retrieved.</param>
        /// <param name="func">An optional predicate used to filter the relation based on a specific condition.</param>
        /// <returns>A cloned instance of <typeparamref name="TBuildingRelation"/> if a matching relation is found; otherwise, <c>null</c>.</returns>
        public TBuildingRelation? GetRelation<TBuildingRelation>(IBuildingGuidObject? buildingUniqueObject, Func<TBuildingRelation?, bool>? func = null) where TBuildingRelation : IBuildingRelation
        {
            if (buildingUniqueObject == null || buildingRelationCluster == null)
            {
                return default;
            }

            GuidReference guidReference = new(buildingUniqueObject);
            if (guidReference is null)
            {
                return default;
            }

            if (!buildingRelationCluster.Contains(guidReference))
            {
                return default;
            }

            TBuildingRelation? result = buildingRelationCluster.GetRelation(guidReference, func);

            return result == null ? default : result.Clone<TBuildingRelation>();
        }

        /// <summary>
        /// Retrieves a list of building relations associated with the specified unique object, optionally filtered by a predicate.
        /// </summary>
        /// <typeparam name="TBuildingRelation">The type of building relation to retrieve, which must implement <see cref="IBuildingRelation"/>.</typeparam>
        /// <param name="buildingUniqueObject">The unique building object for which relations are retrieved.</param>
        /// <param name="func">An optional predicate function used to filter the returned relations.</param>
        /// <returns>A list of matching <typeparamref name="TBuildingRelation"/> instances, or <see langword="null"/> if no relations exist or the input object is null.</returns>
        public List<TBuildingRelation>? GetRelations<TBuildingRelation>(IBuildingGuidObject? buildingUniqueObject, Func<TBuildingRelation?, bool>? func = null) where TBuildingRelation : IBuildingRelation
        {
            if (buildingUniqueObject == null || buildingRelationCluster == null)
            {
                return null;
            }

            GuidReference? guidReference = new(buildingUniqueObject);
            if (guidReference is null)
            {
                return null;
            }

            if (!buildingRelationCluster.Contains(guidReference))
            {
                return null;
            }

            return buildingRelationCluster.GetRelations(guidReference, func)?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Gets the construction associated with the specified roof.
        /// <para>The construction is the one established by <see cref="Assign(IRoof, IRoofConstruction)"/> for the identifier of the given roof, which is why a component rebuilt under the same identifier keeps its construction.</para>
        /// </summary>
        /// <param name="roof">The roof for which to retrieve the construction.</param>
        /// <returns>A CLONE of the <see cref="IRoofConstruction"/> associated with the roof, or <see langword="null"/> if no such construction exists or the <paramref name="roof"/> is null.</returns>
        public IRoofConstruction? GetRoofConstruction(IRoof? roof)
        {
            return GetPhysicalComponentConstruction<IRoofConstruction>(roof);
        }

        /// <summary>
        /// Retrieves a shell associated with the specified space based on the provided criteria.
        /// <para>The shell carries a <see cref="GuidReference"/> of the space and every one of its faces carries a <see cref="GuidReference"/> of the component it was built from, which is what lets the shell be written back into the model by <see cref="BuildingModelShellUpdater"/> after it was processed geometrically.</para>
        /// </summary>
        /// <param name="space">The space from which to retrieve the shell.</param>
        /// <param name="normalSide">The optional side or orientation of the boundary.</param>
        /// <param name="externalEdgeOrientation">The optional orientation of external edges.</param>
        /// <param name="internalEdgeOrientation">The optional orientation of internal edges.</param>
        /// <param name="tolerance">The distance tolerance for geometric operations. Defaults to <see cref="Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>The <see cref="Shell"/> associated with the space if found; otherwise, <see langword="null"/>.</returns>
        public Shell? GetShell(ISpace? space, Side? normalSide = null, Orientation? externalEdgeOrientation = null, Orientation? internalEdgeOrientation = null, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (space is null)
            {
                return null;
            }

            return GetShells([space], normalSide, externalEdgeOrientation, internalEdgeOrientation, tolerance)?.FirstOrDefault();
        }

        /// <summary>
        /// Retrieves a list of shells associated with the specified spaces, applying optional filters for side orientation, edge orientations, and geometric tolerance.
        /// <para>Every shell carries a <see cref="GuidReference"/> of its space and every face a <see cref="GuidReference"/> of the component it was built from; components whose geometry is not a polygonal face are skipped.</para>
        /// </summary>
        /// <typeparam name="TSpace">The type of space objects, which must implement <see cref="ISpace"/>.</typeparam>
        /// <param name="spaces">A collection of spaces to process.</param>
        /// <param name="normalSide">Optional specification for the side or orientation of a boundary.</param>
        /// <param name="externalEdgeOrientation">Optional specification for the orientation of external edges.</param>
        /// <param name="internalEdgeOrientation">Optional specification for the orientation of internal edges.</param>
        /// <param name="tolerance">The distance tolerance used for geometric operations. Defaults to <see cref="Core.Constants.Tolerance.Distance"/>.</param>
        /// <returns>A list of <see cref="Shell"/> objects if successful; otherwise, null.</returns>
        public List<Shell>? GetShells<TSpace>(IEnumerable<TSpace> spaces, Side? normalSide = null, Orientation? externalEdgeOrientation = null, Orientation? internalEdgeOrientation = null, double tolerance = Core.Constants.Tolerance.Distance) where TSpace : ISpace
        {
            if (spaces is null)
            {
                return null;
            }

            List<Shell> result = [];
            foreach (TSpace space in spaces)
            {
                if (GetComponents<IComponent>(space) is not List<IComponent> components)
                {
                    continue;
                }

                List<Face> faces = [];
                foreach (IComponent component in components)
                {
                    if (Query.Geometry3D<IPolygonalFace3D>(component) is not PolygonalFace3D polygonalFace3D)
                    {
                        continue;
                    }

                    faces.Add(new Face(new GuidReference(component), polygonalFace3D));
                }

                Shell? shell = new(new GuidReference(space), faces);

                if (normalSide is not null || externalEdgeOrientation is not null || internalEdgeOrientation is not null)
                {
                    PolyhedronNormalizationUpdater<Shell> polyhedronNormalizationSolver = new(normalSide, externalEdgeOrientation, internalEdgeOrientation, tolerance)
                    {
                        Value = shell
                    };
                    polyhedronNormalizationSolver.Update();
                }

                if (shell is null)
                {
                    continue;
                }

                result.Add(shell);
            }

            return result;
        }

        /// <summary>
        /// Retrieves the shells for all spaces of type <typeparamref name="TSpace" /> within the building model.
        /// </summary>
        /// <typeparam name="TSpace">The type of space that implements the <see cref="ISpace" /> interface.</typeparam>
        /// <param name="normalSide">Optional specification for the side or orientation of boundary normals.</param>
        /// <param name="externalEdgeOrientation">Optional specification for the orientation of external edges.</param>
        /// <param name="internalEdgeOrientation">Optional specification for the orientation of internal edges.</param>
        /// <param name="tolerance">The distance tolerance used for geometric operations. Defaults to <see cref="Core.Constants.Tolerance.Distance" />.</param>
        /// <returns>A list of <see cref="Shell" /> objects if spaces are found; otherwise, null.</returns>
        public List<Shell>? GetShells<TSpace>(Side? normalSide = null, Orientation? externalEdgeOrientation = null, Orientation? internalEdgeOrientation = null, double tolerance = Core.Constants.Tolerance.Distance) where TSpace : ISpace
        {
            IEnumerable<TSpace>? spaces = buildingRelationCluster.GetSpaces<TSpace>()?.CloneAndFilterNulls();
            if (spaces is null)
            {
                return null;
            }

            return GetShells(spaces, normalSide, externalEdgeOrientation, internalEdgeOrientation, tolerance);
        }

        /// <summary>
        /// Retrieves the internal conditions associated with the specified space.
        /// </summary>
        /// <param name="space">The space for which to retrieve internal conditions.</param>
        /// <returns>A list of <see cref="SpaceInternalCondition"/> objects if found; otherwise, null.</returns>
        public List<SpaceInternalCondition>? GetSpaceInternalConditions(ISpace? space)
        {
            if (buildingRelationCluster == null || space == null)
            {
                return default;
            }

            List<SpaceInternalConditionRelation>? spaceInternalConditionRelations = GetRelations<SpaceInternalConditionRelation>(space);
            if (spaceInternalConditionRelations == null)
            {
                return default;
            }

            List<SpaceInternalCondition> result = [];
            foreach (SpaceInternalConditionRelation spaceInternalConditionRelation in spaceInternalConditionRelations)
            {
                IInternalCondition? internalCondition = buildingRelationCluster.GetInternalCondition(spaceInternalConditionRelation);
                if (internalCondition == null)
                {
                    continue;
                }

                result.Add(new SpaceInternalCondition(internalCondition, spaceInternalConditionRelation.HourRange, spaceInternalConditionRelation.Id));
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of spaces associated with the specified zone.
        /// </summary>
        /// <param name="zone">The zone for which to retrieve the associated spaces.</param>
        /// <returns>A list of <see cref="ISpace"/> objects if the zone is valid and has associated spaces; otherwise, <see langword="null"/>.</returns>
        public List<ISpace>? GetSpaces(IZone? zone)
        {
            if (zone == null)
            {
                return null;
            }

            ZoneRelation? zoneRelation = GetRelation<ZoneRelation>(zone);
            if (zoneRelation == null)
            {
                return null;
            }

            List<ISpace>? spaces = buildingRelationCluster?.GetSpaces(zoneRelation);
            if (spaces == null)
            {
                return null;
            }

            return spaces?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves the list of spaces associated with the specified component.
        /// <para>A component bounds at most two spaces, an external one bounds a single space.</para>
        /// </summary>
        /// <param name="component">The component for which to retrieve the associated spaces.</param>
        /// <returns>A list of CLONED <see cref="ISpace"/> objects if found; otherwise, null.</returns>
        public List<ISpace>? GetSpaces(IComponent? component)
        {
            if (component == null)
            {
                return null;
            }

            SpaceRelation? spaceRelation = GetRelation<SpaceRelation>(component);
            if (spaceRelation == null)
            {
                return null;
            }

            List<ISpace>? spaces = buildingRelationCluster?.GetSpaces(spaceRelation);
            if (spaces == null)
            {
                return null;
            }

            return spaces?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Retrieves a list of spaces associated with the specified opening.
        /// </summary>
        /// <param name="opening">The opening for which to retrieve the associated spaces.</param>
        /// <returns>A list of <see cref="ISpace"/> objects if found; otherwise, null.</returns>
        public List<ISpace>? GetSpaces(IOpening? opening)
        {
            IComponent? component = GetComponent<IComponent>(opening);
            if (component == null)
            {
                return null;
            }

            return GetSpaces(component);
        }

        /// <summary>
        /// Retrieves the spaces associated with the specified internal condition.
        /// </summary>
        /// <typeparam name="TSpace">The type of space to retrieve.</typeparam>
        /// <param name="internalCondition">The internal condition for which to retrieve associated spaces.</param>
        /// <returns>A list of spaces of type <typeparamref name="TSpace"/>, or null if no relations are found.</returns>
        public List<TSpace>? GetSpaces<TSpace>(IInternalCondition? internalCondition) where TSpace : ISpace
        {
            List<SpaceInternalConditionRelation>? spaceInternalConditionRelations = GetRelations<SpaceInternalConditionRelation>(internalCondition);
            if (spaceInternalConditionRelations == null)
            {
                return null;
            }

            List<TSpace> result = [];
            foreach (SpaceInternalConditionRelation spaceInternalConditionRelation in spaceInternalConditionRelations)
            {
                TSpace? space = Core.Query.Clone(buildingRelationCluster.GetSpace<TSpace>(spaceInternalConditionRelation));
                if (space == null)
                {
                    continue;
                }

                result.Add(space);
            }

            return result;
        }

        /// <summary>Retrieves all spaces of the specified type from the building model.</summary>
        /// <typeparam name="TSpace">The type of space to retrieve, which must implement <see cref="ISpace"/>.</typeparam>
        /// <returns>A list containing the retrieved spaces of type <typeparamref name="TSpace"/>, or null if no such spaces are found.</returns>
        public List<TSpace>? GetSpaces<TSpace>() where TSpace : ISpace
        {
            return buildingRelationCluster.GetSpaces<TSpace>()?.CloneAndFilterNulls();
        }

        /// <summary>
        /// Gets the wall construction for the specified wall.
        /// <para>The construction is the one established by <see cref="Assign(IWall, IWallConstruction)"/> for the identifier of the given wall, which is why a component rebuilt under the same identifier keeps its construction.</para>
        /// </summary>
        /// <param name="wall">The wall for which to retrieve the construction.</param>
        /// <returns>A CLONE of the <see cref="IWallConstruction"/> associated with the wall, or <see langword="null"/> if no construction is found or the wall is null.</returns>
        public IWallConstruction? GetWallConstruction(IWall? wall)
        {
            return GetPhysicalComponentConstruction<IWallConstruction>(wall);
        }

        /// <summary>
        /// Gets the window construction for the specified window.
        /// </summary>
        /// <param name="window">The window for which to retrieve the construction.</param>
        /// <returns>The <see cref="IWindowConstruction"/> associated with the window, or <c>null</c> if no construction is found or the provided window is null.</returns>
        public IWindowConstruction? GetWindowConstruction(IWindow? window)
        {
            return GetOpeningConstruction<IWindowConstruction>(window);
        }

        /// <summary>Retrieves all zones of the specified type from the building model.</summary>
        /// <typeparam name="TZone">The type of zone to retrieve, which must implement <see cref="IZone"/>.</typeparam>
        /// <returns>A list containing the retrieved zones of type <typeparamref name="TZone"/>, or null if no such zones are found.</returns>
        public List<TZone>? GetZones<TZone>() where TZone : IZone
        {
            return buildingRelationCluster.GetValues<TZone>().CloneAndFilterNulls();
        }

        /// <summary>
        /// Determines whether the building model is contained within the specified sphere.
        /// </summary>
        /// <param name="sphere">The sphere used to check for containment.</param>
        /// <param name="tolerance">The distance tolerance used for the geometric operation.</param>
        /// <returns>True if all components of the building are inside the sphere; otherwise, false.</returns>
        public bool Inside(Sphere? sphere, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (sphere == null)
            {
                return false;
            }

            List<IComponent>? components = buildingRelationCluster.GetValues<IComponent>();
            if (components == null || components.Count() == 0)
            {
                return false;
            }

            foreach (IComponent component in components)
            {
                if (!Query.Inside(sphere, component, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Removes the specified construction from the building model.
        /// </summary>
        /// <param name="construction">The construction to be removed.</param>
        /// <returns>True if the construction was successfully removed; otherwise, false.</returns>
        public bool Remove(IConstruction? construction)
        {
            return Remove(construction == null ? null : new GuidReference(construction));
        }

        /// <summary>
        /// Removes the specified space from the building model.
        /// </summary>
        /// <param name="space">The space to be removed.</param>
        /// <returns>True if the space was successfully removed; otherwise, false.</returns>
        public bool Remove(ISpace? space)
        {
            return Remove(space == null ? null : new GuidReference(space));
        }

        /// <summary>
        /// Removes the specified component from the building model.
        /// </summary>
        /// <param name="component">The component to be removed.</param>
        /// <returns>True if the component was successfully removed; otherwise, false.</returns>
        public bool Remove(IComponent? component)
        {
            return Remove(component == null ? null : new GuidReference(component));
        }

        /// <summary>
        /// Removes the opening associated with the specified opening object.
        /// </summary>
        /// <param name="opening">The opening to remove.</param>
        /// <returns>True if the opening was successfully removed; otherwise, false.</returns>
        public bool Remove(IOpening? opening)
        {
            return Remove(opening == null ? null : new GuidReference(opening));
        }

        /// <summary>
        /// Removes the specified zone from the building model.
        /// </summary>
        /// <param name="zone">The zone to be removed.</param>
        /// <returns>True if the zone was successfully removed; otherwise, false.</returns>
        public bool Remove(IZone? zone)
        {
            return Remove(zone == null ? null : new GuidReference(zone));
        }

        /// <summary>
        /// Removes the specified internal condition from the building model.
        /// </summary>
        /// <param name="internalCondition">The internal condition to remove.</param>
        /// <returns>True if the internal condition was successfully removed; otherwise, false.</returns>
        public bool Remove(IInternalCondition? internalCondition)
        {
            return Remove(internalCondition == null ? null : new GuidReference(internalCondition));
        }

        /// <summary>
        /// Removes the shade associated with the specified object from the building model.
        /// </summary>
        /// <param name="shade">The shade to be removed.</param>
        /// <returns>True if the shade was successfully removed; otherwise, false.</returns>
        public bool Remove(IShade? shade)
        {
            return Remove(shade == null ? null : new GuidReference(shade));
        }

        /// <summary>
        /// Removes the object associated with the specified GUID reference from the building model.
        /// </summary>
        /// <param name="guidReference">The <see cref="GuidReference"/> of the object to remove.</param>
        /// <returns><see langword="true"/> if the object was successfully removed; otherwise, <see langword="false"/>.</returns>
        public bool Remove(GuidReference? guidReference)
        {
            if (guidReference is null)
            {
                return false;
            }

            return buildingRelationCluster.Remove(guidReference);
        }

        /// <summary>
        /// Attempts to retrieve a building GUID object from the model using the specified reference.
        /// </summary>
        /// <typeparam name="TBuildingGuidObject">The type of the building GUID object to be retrieved.</typeparam>
        /// <param name="guidReference">The <see cref="GuidReference"/> used to identify the object.</param>
        /// <param name="buildingUniqueObject">When this method returns <see langword="true"/>, contains the cloned instance of the retrieved object; otherwise, it is set to <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the object was successfully found and retrieved; otherwise, <see langword="false"/>.</returns>
        public bool TryGetObject<TBuildingGuidObject>(GuidReference? guidReference, out TBuildingGuidObject? buildingUniqueObject) where TBuildingGuidObject : IBuildingGuidObject
        {
            buildingUniqueObject = default;

            if (guidReference is null || buildingRelationCluster is null)
            {
                return false;
            }

            bool result = buildingRelationCluster.TryGetValue(guidReference, out TBuildingGuidObject? buildingUniqueObject_Temp);

            if (result && buildingUniqueObject_Temp != null)
            {
                buildingUniqueObject = buildingUniqueObject_Temp.Clone<TBuildingGuidObject>();
            }

            return result;
        }

        /// <summary>
        /// Unassigns a component from a specific space by removing the association between them.
        /// <para>The component itself stays in the model; when the space was its last one the whole space relation is dropped, leaving the component unassigned.</para>
        /// </summary>
        /// <param name="component">The component to be unassigned.</param>
        /// <param name="space">The space from which the component should be removed.</param>
        /// <returns>True if the component was successfully unassigned; otherwise, false.</returns>
        /// <seealso cref="Assign(IComponent, ISpace, ISpace)"/>
        public bool Unassign(IComponent? component, ISpace? space)
        {
            if (component == null || space == null)
            {
                return false;
            }

            SpaceRelation? spaceRelation = GetRelation<SpaceRelation>(component);
            if (spaceRelation == null)
            {
                return false;
            }

            GuidReference guidReference = new(space);

            if (!spaceRelation.Remove(RelationSide.To, guidReference))
            {
                return false;
            }

            List<IUniqueReference>? uniqueReferences = spaceRelation.UniqueReferences_To;
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                buildingRelationCluster.Remove(spaceRelation);
            }

            return true;
        }

        /// <summary>
        /// Unassigns a space from a specific zone within the building model.
        /// </summary>
        /// <param name="zone">The zone from which the space should be unassigned. Can be null.</param>
        /// <param name="space">The space to be removed from the zone's association. Can be null.</param>
        /// <returns>True if the space was successfully unassigned from the zone; otherwise, false.</returns>
        public bool Unassign(IZone? zone, ISpace? space)
        {
            if (zone == null || space == null)
            {
                return false;
            }

            ZoneRelation? zoneRelation = GetRelation<ZoneRelation>(zone);
            if (zoneRelation == null)
            {
                return false;
            }

            GuidReference guidReference = new(space);

            if (!zoneRelation.Remove(RelationSide.To, guidReference))
            {
                return false;
            }

            List<IUniqueReference>? uniqueReferences = zoneRelation.UniqueReferences_To;
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                buildingRelationCluster.Remove(zoneRelation);
            }

            return true;
        }

        /// <summary>
        /// Unassigns a component from a specific opening.
        /// </summary>
        /// <param name="component">The component to be unassigned.</param>
        /// <param name="opening">The opening from which the component is being removed.</param>
        /// <returns>True if the unassignment was successful; otherwise, false.</returns>
        public bool Unassign(IComponent? component, IOpening? opening)
        {
            if (component == null || opening == null)
            {
                return false;
            }

            OpeningRelation? openingRelation = GetRelation<OpeningRelation>(component);
            if (openingRelation == null)
            {
                return false;
            }

            List<IUniqueReference>? uniqueReferences = openingRelation?.UniqueReferences_To;
            if (uniqueReferences == null)
            {
                return false;
            }

            if (uniqueReferences.Count == 1)
            {
                buildingRelationCluster.Remove(openingRelation);
            }
            else
            {
                openingRelation!.Remove(RelationSide.To, new GuidReference(opening));
            }

            return true;
        }

        /// <summary>
        /// Updates the building model by adding a clone of the specified component to the relation cluster.
        /// <para>The component is stored under its own identifier, therefore a component carrying the identifier of one already held by the model REPLACES it, keeping the relations established for that identifier. That is how a component is rebuilt with a new geometry - see <see cref="BuildingModelFaceUpdater"/>.</para>
        /// </summary>
        /// <param name="component">The component to be updated in the model; can be null.</param>
        /// <returns>True if the component was successfully added to the relation cluster; otherwise, false.</returns>
        public bool Update(IComponent? component)
        {
            if (component == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(component.Clone<IComponent>());
        }

        /// <summary>
        /// Updates the building model by adding the specified construction to the relation cluster.
        /// </summary>
        /// <param name="construction">The construction object to be updated.</param>
        /// <returns>True if the construction was successfully added; otherwise, false.</returns>
        public bool Update(IConstruction? construction)
        {
            if (construction == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(construction.Clone<IConstruction>());
        }

        /// <summary>
        /// Updates the building model by adding a clone of the specified space to the relation cluster.
        /// <para>The space is stored under its own identifier, therefore a space carrying the identifier of one already held by the model replaces it and keeps the relations established for that identifier.</para>
        /// </summary>
        /// <param name="space">The space object to be added or updated in the building model.</param>
        /// <returns>True if the space was successfully added; otherwise, false.</returns>
        public bool Update(ISpace? space)
        {
            if (space == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(space.Clone<ISpace>());
        }

        /// <summary>
        /// Updates the building model by adding the specified internal condition.
        /// </summary>
        /// <param name="internalCondition">The internal condition to be updated.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public bool Update(IInternalCondition? internalCondition)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(internalCondition.Clone<IInternalCondition>());
        }

        /// <summary>
        /// Updates the building model with the specified zone.
        /// </summary>
        /// <param name="zone">The zone to update. Can be <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the zone was successfully updated; otherwise, <see langword="false"/>.</returns>
        public bool Update(IZone? zone)
        {
            if (zone == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(zone.Clone<IZone>());
        }

        /// <summary>
        /// Updates the building model by adding or updating the specified opening within the relation cluster.
        /// </summary>
        /// <param name="opening">The opening object to be updated.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public bool Update(IOpening? opening)
        {
            if (opening == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(opening.Clone<IOpening>());
        }

        /// <summary>
        /// Updates the building model by adding or updating the specified shade in the relation cluster.
        /// </summary>
        /// <param name="shade">The shade object to be updated.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public bool Update(IShade? shade)
        {
            if (shade == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(shade.Clone<IShade>());
        }

        private bool Assign(IComponent? component, IOpening? opening)
        {
            if (component == null || opening == null)
            {
                return false;
            }

            if (!Update(component))
            {
                return false;
            }

            if (!Update(opening))
            {
                return false;
            }

            GuidReference guidReference = new(opening);

            OpeningRelation? openingRelation = GetRelation<OpeningRelation>(opening);
            if (openingRelation != null)
            {
                List<IUniqueReference>? uniqueReferences = openingRelation.UniqueReferences_To;
                if (uniqueReferences != null)
                {
                    if (uniqueReferences.Count == 1)
                    {
                        buildingRelationCluster.Remove(openingRelation);
                    }
                    else
                    {
                        openingRelation.Remove(RelationSide.To, guidReference);
                    }
                }
            }

            List<IOpening>? openings = null;

            openingRelation = GetRelation<OpeningRelation>(component);
            if (openingRelation != null)
            {
                buildingRelationCluster.Remove(openingRelation);

                buildingRelationCluster.TryGetValues(openingRelation.UniqueReferences_To?.FindAll(x => x is GuidReference).Cast<GuidReference>(), out openings);
            }

            openings ??= [];

            openings.Add(opening);

            buildingRelationCluster.AddRelation(new OpeningRelation(component, openings));

            return true;
        }

        private TOpeningConstruction? GetOpeningConstruction<TOpeningConstruction>(IOpening? opening) where TOpeningConstruction : IOpeningConstruction
        {
            if (buildingRelationCluster == null || opening == null)
            {
                return default;
            }

            OpeningConstructionRelation? openingConstructionRelation = GetRelation<OpeningConstructionRelation>(opening);
            if (openingConstructionRelation == null)
            {
                return default;
            }

            IOpeningConstruction? openingConstruction = buildingRelationCluster.GetOpeningConstruction(openingConstructionRelation);
            if (openingConstruction is TOpeningConstruction openingConstruction_Temp)
            {
                return openingConstruction_Temp.Clone<TOpeningConstruction>();
            }

            return default;
        }

        private TPhysicalComponentConstruction? GetPhysicalComponentConstruction<TPhysicalComponentConstruction>(IPhysicalComponent? physicalComponent) where TPhysicalComponentConstruction : IPhysicalComponentConstruction
        {
            if (buildingRelationCluster == null || physicalComponent == null)
            {
                return default;
            }

            PhysicalComponentConstructionRelation? physicalComponentConstructionRelation = GetRelation<PhysicalComponentConstructionRelation>(physicalComponent);
            if (physicalComponentConstructionRelation == null)
            {
                return default;
            }

            IPhysicalComponentConstruction? physicalComponentConstruction = buildingRelationCluster.GetPhysicalComponentConstruction(physicalComponentConstructionRelation);
            if (physicalComponentConstruction is TPhysicalComponentConstruction result)
            {
                return result.Clone<TPhysicalComponentConstruction>();
            }

            return default;
        }
    }
}