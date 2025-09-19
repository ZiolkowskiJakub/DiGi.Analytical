using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using DiGi.Core.Relation.Enums;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingModel : ParametrizedGuidObject, IBuildingGuidObject, IGuidModel, IBuildingBoundable3D
    {
        [JsonInclude, JsonPropertyName("BuildingRelationCluster"), System.ComponentModel.Description("BuildingRelationCluster")]
        private readonly BuildingRelationCluster buildingRelationCluster = [];

        [JsonInclude, JsonPropertyName("BuildingInformation"), System.ComponentModel.Description("BuildingInformation")]
        private BuildingInformation buildingInformation = new ();
        public BuildingModel() 
            : base()
        {
            
        }

        public BuildingModel(BuildingModel? buildingModel)
            : base(buildingModel)
        {
            if(buildingModel != null)
            {
                buildingRelationCluster = Core.Query.Clone(buildingModel.buildingRelationCluster) ?? [];
            }
        }

        public BuildingModel(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

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
            foreach(ISpace space in spaces)
            {
                if (Update(space))
                {
                    spaces_Temp.Add(space);
                }
            }

            return buildingRelationCluster.AddRelation(zone, spaces_Temp) != null;
        }

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

        public bool Assign<TSpace>(IEnumerable<TSpace>? spaces, IInternalCondition? internalCondition, HourRange? hourRange, string? id = null) where TSpace : ISpace
        {
            if (internalCondition == null || spaces == null)
            {
                return false;
            }

            bool result = false;
            foreach(TSpace space in spaces)
            {
                if(Assign(space, internalCondition, hourRange, id))
                {
                    result = true;
                }
            }

            return result;
        }

        public List<Shell>? GetShells<TSpace>(IEnumerable<TSpace> spaces, Side? normalSide = null, Orientation? externalEdgeOrientation = null, Orientation? internalEdgeOrientation = null, double tolerance = Core.Constans.Tolerance.Distance) where TSpace : ISpace
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

                if(shell is null)
                {
                    continue;
                }

                result.Add(shell);
            }

            return result;
        }

        public Shell? GetShell(ISpace? space, Side? normalSide = null, Orientation? externalEdgeOrientation = null, Orientation? internalEdgeOrientation = null, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if(space is null)
            {
                return null;
            }

            return GetShells([space], normalSide, externalEdgeOrientation, internalEdgeOrientation, tolerance)?.FirstOrDefault();
        }

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

        public List<TComponent>? GetComponents<TComponent>(IComponentConstruction? componentConstruction) where TComponent : IComponent
        {
            if (buildingRelationCluster == null || componentConstruction == null)
            {
                return null;
            }

            List<ComponentConstructionRelation>? componentConstructionRelations = GetRelations<ComponentConstructionRelation>(componentConstruction);
            if (componentConstructionRelations == null)
            {
                return default;
            }

            List<TComponent> result = [];
            foreach (ComponentConstructionRelation constructionRelation in componentConstructionRelations)
            {
                IComponent? component = buildingRelationCluster.GetComponent(constructionRelation);
                if (component is TComponent component_Temp)
                {
                    result.Add(component_Temp);
                }
            }

            return result.CloneAndFilterNulls();
        }

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

        public List<TComponent>? GetComponents<TComponent>(ISpace? space_1, ISpace? space_2) where TComponent : IComponent
        {
            if (buildingRelationCluster == null || space_1 == null || space_2 == null)
            {
                return null;
            }

            GuidReference guidReference = new(space_2);

            List<SpaceRelation>? spaceRelations = GetRelations(space_1, (SpaceRelation? x) =>  x?.UniqueReferences_To is not null && x.UniqueReferences_To.Contains(guidReference));
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

        public List<TComponent>? GetComponents<TComponent>() where TComponent : IComponent
        {
            return buildingRelationCluster.GetComponents<TComponent>().CloneAndFilterNulls();
        }

        public IWallConstruction? GetConstruction(IWall? wall)
        {
            return GetConstruction<IWallConstruction>(wall);
        }

        public IFloorConstruction? GetConstruction(IFloor? wall)
        {
            return GetConstruction<IFloorConstruction>(wall);
        }

        public IRoofConstruction? GetConstruction(IRoof? roof)
        {
            return GetConstruction<IRoofConstruction>(roof);
        }

        public IWindowConstruction? GetConstruction(IWindow? window)
        {
            return GetConstruction<IWindowConstruction>(window);
        }

        public IDoorConstruction? GetConstruction(IDoor? door)
        {
            return GetConstruction<IDoorConstruction>(door);
        }

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
            foreach(SpaceInternalConditionRelation spaceInternalConditionRelation in spaceInternalConditionRelations)
            {
                IInternalCondition? internalCondition = buildingRelationCluster.GetInternalCondition(spaceInternalConditionRelation);
                if (internalCondition is TInternalCondition internalCondition_Temp)
                {
                    TInternalCondition? internalCondition_Temp_Temp = internalCondition_Temp.Clone<TInternalCondition>();
                    if(internalCondition_Temp_Temp != null)
                    {
                        result.Add(internalCondition_Temp_Temp);
                    }
                }
            }

            return result;
        }

        public TBuildingGuidObject? GetObject<TBuildingGuidObject>(GuidReference? uniqueReference) where TBuildingGuidObject : IBuildingGuidObject
        {
            if (!TryGetObject(uniqueReference, out TBuildingGuidObject? result))
            {
                return result;
            }

            return default;
        }

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

        public List<TOpening>? GetOpenings<TOpening>(Func<TOpening?, bool>? func = null) where TOpening : IOpening
        {
            if (buildingRelationCluster == null)
            {
                return null;
            }

            return buildingRelationCluster?.GetValues(func)?.CloneAndFilterNulls();
        }

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
        
        public List<ISpace>? GetSpaces(IZone? zone)
        {
            if(zone == null)
            {
                return null;
            }

            ZoneRelation? zoneRelation = GetRelation<ZoneRelation>(zone);
            if(zoneRelation == null)
            {
                return null;
            }

            List<ISpace>? spaces = buildingRelationCluster?.GetSpaces(zoneRelation);
            if(spaces == null)
            {
                return null;
            }

            return spaces?.CloneAndFilterNulls();
        }

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

        public List<ISpace>? GetSpaces(IOpening? opening)
        {
            IComponent? component = GetComponent<IComponent>(opening);
            if(component == null)
            {
                return null;
            }

            return GetSpaces(component);
        }

        public List<TSpace>? GetSpaces<TSpace>(IInternalCondition? internalCondition) where TSpace : ISpace
        {
            List<SpaceInternalConditionRelation>? spaceInternalConditionRelations = GetRelations<SpaceInternalConditionRelation>(internalCondition);
            if(spaceInternalConditionRelations == null)
            {
                return null;
            }

            List<TSpace> result = [];
            foreach(SpaceInternalConditionRelation spaceInternalConditionRelation in spaceInternalConditionRelations)
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

        public List<TSpace>? GetSpaces<TSpace>() where TSpace : ISpace
        {
            return buildingRelationCluster.GetSpaces<TSpace>()?.CloneAndFilterNulls();
        }

        public bool Inside(Sphere? sphere, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if(sphere == null)
            {
                return false;
            }

            List<IComponent>? components = buildingRelationCluster.GetValues<IComponent>();
            if(components == null || components.Count() == 0)
            {
                return false;
            }

            foreach(IComponent component in components)
            {
                if(!Query.Inside(sphere, component, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        public bool Remove(IConstruction? construction)
        {
            return Remove(construction == null ? null : new GuidReference(construction));
        }

        public bool Remove(ISpace? space)
        {
            return Remove(space == null ? null : new GuidReference(space));
        }

        public bool Remove(IComponent? component)
        {
            return Remove(component == null ? null : new GuidReference(component));
        }

        public bool Remove(IOpening? opening)
        {
            return Remove(opening == null ? null : new GuidReference(opening));
        }

        public bool Remove(IZone? zone)
        {
            return Remove(zone == null ? null : new GuidReference(zone));
        }

        public bool Remove(IInternalCondition? internalCondition)
        {
            return Remove(internalCondition == null ? null : new GuidReference(internalCondition));
        }

        public bool Remove(IShade? shade)
        {
            return Remove(shade == null ? null : new GuidReference(shade));
        }

        public bool Remove(GuidReference? guidReference)
        {
            if (guidReference is null)
            {
                return false;
            }

            return buildingRelationCluster.Remove(guidReference);
        }

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

        public bool Update(IComponent? component)
        {
            if (component == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(component.Clone<IComponent>());
        }

        public bool Update(IConstruction? construction)
        {
            if (construction == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(construction.Clone<IConstruction>());
        }

        public bool Update(ISpace? space)
        {
            if (space == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(space.Clone<ISpace>());
        }

        public bool Update(IInternalCondition? internalCondition)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(internalCondition.Clone<IInternalCondition>());
        }

        public bool Update(IZone? zone)
        {
            if (zone == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(zone.Clone<IZone>());
        }

        public bool Update(IOpening? opening)
        {
            if (opening == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(opening.Clone<IOpening>());
        }

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
            if(component == null || opening == null)
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
            if(openingRelation != null)
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
            if(openingRelation != null)
            {
                buildingRelationCluster.Remove(openingRelation);

                buildingRelationCluster.TryGetValues(openingRelation.UniqueReferences_To?.FindAll(x => x is GuidReference).Cast<GuidReference>(), out openings);
            }

            openings ??= [];

            openings.Add(opening);

            buildingRelationCluster.AddRelation(new OpeningRelation(component, openings));

            return true;
        }

        private TConstruction? GetConstruction<TConstruction>(IComponent? component) where TConstruction : IConstruction
        {
            if (buildingRelationCluster == null || component == null)
            {
                return default;
            }

            ComponentConstructionRelation? componentConstructionRelation = GetRelation<ComponentConstructionRelation>(component);
            if (componentConstructionRelation == null)
            {
                return default;
            }

            IConstruction? construction = buildingRelationCluster.GetConstruction(componentConstructionRelation);
            if(construction is TConstruction construction_Temp)
            {
                return construction_Temp.Clone<TConstruction>();
            }

            return  default;
        }

        private TOpeningConstruction? GetConstruction<TOpeningConstruction>(IOpening? opening) where TOpeningConstruction : IOpeningConstruction
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
    }
}
