using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.Text.Json.Serialization;
using DiGi.Core;
using System.Collections.Generic;
using DiGi.Core.Classes;
using System;
using System.Linq;
using DiGi.Core.Relation.Enums;
using System.Text.Json.Nodes;
using DiGi.Analytical.Classes;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingModel : ParametrizedGuidObject, IBuildingGuidObject, IGuidModel
    {
        [JsonInclude, JsonPropertyName("BuildingRelationCluster"), System.ComponentModel.Description("BuildingRelationCluster")]
        private BuildingRelationCluster buildingRelationCluster = new BuildingRelationCluster();

        public BuildingModel() 
            : base()
        {
            
        }

        public BuildingModel(BuildingModel buildingModel)
            : base(buildingModel)
        {
            if(buildingModel != null)
            {
                buildingRelationCluster = Core.Query.Clone(buildingModel.buildingRelationCluster);
            }
        }

        public BuildingModel(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public bool Assign(IWall wall, IWallConstruction wallConstruction)
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

        public bool Assign(IRoof roof, IRoofConstruction roofConstruction)
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

        public bool Assign(IFloor floor, IFloorConstruction floorConstruction)
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

        public bool Assign(IWindow window, IWindowConstruction windowConstruction)
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

        public bool Assign(IDoor door, IDoorConstruction doorConstruction)
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

        public bool Assign(IComponent component, ISpace space_1, ISpace space_2 = null)
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

        public bool Assign(IZone zone, IEnumerable<ISpace> spaces)
        {
            if (zone == null || spaces == null)
            {
                return false;
            }

            if (!Update(zone))
            {
                return false;
            }

            List<ISpace> spaces_Temp = new List<ISpace>();
            foreach(ISpace space in spaces)
            {
                if (Update(space))
                {
                    spaces_Temp.Add(space);
                }
            }

            return buildingRelationCluster.AddRelation(zone, spaces_Temp) != null;
        }

        public bool Assign(ISpace space, IInternalCondition internalCondition, HourRange hourRange, string id = null)
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

        public bool Assign<TSpace>(IEnumerable<TSpace> spaces, IInternalCondition internalCondition, HourRange hourRange, string id = null) where TSpace : ISpace
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

        public T GetComponent<T>(IOpening opening) where T : IComponent
        {
            if (opening == null)
            {
                return default;
            }

            OpeningRelation openingRelation = GetRelation<OpeningRelation>(opening);
            if (opening == null)
            {
                return default;
            }

            IComponent component = buildingRelationCluster?.GetComponent(openingRelation);
            if (component == null)
            {
                return default;
            }

            if (component is T)
            {
                return ((T)component).Clone<T>();
            }

            return default;
        }

        public List<T> GetComponents<T>(IComponentConstruction componentConstruction) where T : IComponent
        {
            if (buildingRelationCluster == null || componentConstruction == null)
            {
                return null;
            }

            List<ComponentConstructionRelation> componentConstructionRelations = GetRelations<ComponentConstructionRelation>(componentConstruction);
            if (componentConstructionRelations == null)
            {
                return default;
            }

            List<T> result = new List<T>();
            foreach (ComponentConstructionRelation constructionRelation in componentConstructionRelations)
            {
                IComponent component = buildingRelationCluster.GetComponent(constructionRelation);
                if (component is T)
                {
                    result.Add((T)component);
                }
            }

            return result.ConvertAll(x => x.Clone<T>());
        }

        public List<T> GetComponents<T>(ISpace space) where T : IComponent
        {
            if (buildingRelationCluster == null || space == null)
            {
                return null;
            }

            List<SpaceRelation> spaceRelations = GetRelations<SpaceRelation>(space);
            if (spaceRelations == null)
            {
                return default;
            }

            List<T> result = new List<T>();
            foreach (SpaceRelation spaceRelation in spaceRelations)
            {
                IComponent component = buildingRelationCluster.GetComponent(spaceRelation);
                if (component is T)
                {
                    result.Add((T)component);
                }
            }

            return result.ConvertAll(x => x.Clone<T>());
        }

        public List<T> GetComponents<T>(ISpace space_1, ISpace space_2) where T : IComponent
        {
            if (buildingRelationCluster == null || space_1 == null || space_2 == null)
            {
                return null;
            }

            GuidReference guidReference = new GuidReference(space_2);

            List<SpaceRelation> spaceRelations = GetRelations(space_1, (SpaceRelation x) => x.UniqueReferences_To.Contains(guidReference));
            if (spaceRelations == null)
            {
                return default;
            }

            List<T> result = new List<T>();
            foreach (SpaceRelation spaceRelation in spaceRelations)
            {
                IComponent component = buildingRelationCluster.GetComponent(spaceRelation);
                if (component is T)
                {
                    result.Add((T)component);
                }
            }

            return result.ConvertAll(x => x.Clone<T>());
        }

        public List<TComponent> GetComponents<TComponent>() where TComponent : IComponent
        {
            return buildingRelationCluster.GetComponents<TComponent>().ConvertAll(x => x.Clone<TComponent>());
        }

        public IWallConstruction GetConstruction(IWall wall)
        {
            return GetConstruction<IWallConstruction>(wall);
        }

        public IFloorConstruction GetConstruction(IFloor wall)
        {
            return GetConstruction<IFloorConstruction>(wall);
        }

        public IRoofConstruction GetConstruction(IRoof roof)
        {
            return GetConstruction<IRoofConstruction>(roof);
        }

        public IWindowConstruction GetConstruction(IWindow window)
        {
            return GetConstruction<IWindowConstruction>(window);
        }

        public IDoorConstruction GetConstruction(IDoor door)
        {
            return GetConstruction<IDoorConstruction>(door);
        }

        public List<TInternalCondition> GetInternalConditions<TInternalCondition>(ISpace space) where TInternalCondition : IInternalCondition
        {
            if (buildingRelationCluster == null || space == null)
            {
                return default;
            }

            List<SpaceInternalConditionRelation> spaceInternalConditionRelations = GetRelations<SpaceInternalConditionRelation>(space);
            if (spaceInternalConditionRelations == null)
            {
                return default;
            }

            List<TInternalCondition> result = new List<TInternalCondition>();
            foreach(SpaceInternalConditionRelation spaceInternalConditionRelation in spaceInternalConditionRelations)
            {
                IInternalCondition internalCondition = buildingRelationCluster.GetInternalCondition(spaceInternalConditionRelation);
                if (internalCondition is TInternalCondition)
                {
                    TInternalCondition internalCondition_Temp = ((TInternalCondition)internalCondition).Clone<TInternalCondition>();
                    if(internalCondition_Temp != null)
                    {
                        result.Add(internalCondition_Temp);
                    }
                }
            }

            return result;
        }

        public T GetObject<T>(GuidReference uniqueReference) where T : IBuildingGuidObject
        {
            if (!TryGetObject(uniqueReference, out T result))
            {
                return result;
            }

            return default;
        }

        public T GetObject<T>(IBuildingRelation buildingRelation) where T : IBuildingGuidObject
        {
            if (buildingRelation == null || buildingRelationCluster == null)
            {
                return default;
            }

            List<IUniqueReference> uniqueReferences = buildingRelation?.UniqueReferences;
            if (uniqueReferences == null)
            {
                return default;
            }

            foreach (IUniqueReference uniqueReference in uniqueReferences)
            {
                GuidReference guidReference = uniqueReference as GuidReference;
                if (guidReference == null)
                {
                    continue;
                }

                if (!buildingRelationCluster.TryGetValue(guidReference, out T result))
                {
                    return result.Clone<T>();
                }
            }

            return default;
        }

        public List<T> GetObjects<T>(IBuildingRelation buildingRelation) where T : IBuildingGuidObject
        {
            if (buildingRelation == null || buildingRelationCluster == null)
            {
                return null;
            }

            List<IUniqueReference> uniqueReferences = buildingRelation?.UniqueReferences;
            if (uniqueReferences == null)
            {
                return null;
            }

            if (!buildingRelationCluster.TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<T> result))
            {
                return null;
            }

            return result.ConvertAll(x => x.Clone<T>());
        }

        public List<T> GetOpenings<T>(IComponent component) where T : IOpening
        {
            if (buildingRelationCluster == null || component == null)
            {
                return null;
            }

            OpeningRelation openingRelation = GetRelation<OpeningRelation>(component);
            if (openingRelation == null)
            {
                return null;
            }

            List<IUniqueReference> uniqueReferences = openingRelation.UniqueReferences_To;
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                return null;
            }

            if (!buildingRelationCluster.TryGetValues(uniqueReferences.FindAll(x => x is GuidReference).Cast<GuidReference>(), out List<T> result))
            {
                return null;
            }

            return result;
        }

        public List<T> GetOpenings<T>(Func<T, bool> func = null) where T : IOpening
        {
            if (buildingRelationCluster == null)
            {
                return null;
            }

            return buildingRelationCluster?.GetValues(func)?.ConvertAll(x => x.Clone<T>());
        }

        public List<T> GetOpenings<T>(IOpeningConstruction openingConstruction) where T : IOpening
        {
            if (buildingRelationCluster == null || openingConstruction == null)
            {
                return null;
            }

            List<OpeningConstructionRelation> openingConstructionRelations = GetRelations<OpeningConstructionRelation>(openingConstruction);
            if (openingConstructionRelations == null)
            {
                return default;
            }

            List<T> result = new List<T>();
            foreach (OpeningConstructionRelation openingConstructionRelation in openingConstructionRelations)
            {
                IOpening opening = buildingRelationCluster.GetOpening(openingConstructionRelation);
                if (opening is T)
                {
                    result.Add((T)opening);
                }
            }

            return result.ConvertAll(x => x.Clone<T>());
        }

        public T GetRelation<T>(IBuildingGuidObject buildingUniqueObject, Func<T, bool> func = null) where T : IBuildingRelation
        {
            if (buildingUniqueObject == null || buildingRelationCluster == null)
            {
                return default;
            }

            GuidReference guidReference = new GuidReference(buildingUniqueObject);
            if (guidReference == null)
            {
                return default;
            }

            if (!buildingRelationCluster.Contains(guidReference))
            {
                return default;
            }

            T result = buildingRelationCluster.GetRelation(guidReference, func);

            return result == null ? default : result.Clone<T>();
        }

        public List<T> GetRelations<T>(IBuildingGuidObject buildingUniqueObject, Func<T, bool> func = null) where T : IBuildingRelation
        {
            if (buildingUniqueObject == null || buildingRelationCluster == null)
            {
                return null;
            }

            GuidReference guidReference = new GuidReference(buildingUniqueObject);
            if (guidReference == null)
            {
                return null;
            }

            if (!buildingRelationCluster.Contains(guidReference))
            {
                return null;
            }

            return buildingRelationCluster.GetRelations(guidReference, func)?.ConvertAll(x => x.Clone<T>());
        }

        public List<SpaceInternalCondition> GetSpaceInternalConditions(ISpace space)
        {
            if (buildingRelationCluster == null || space == null)
            {
                return default;
            }

            List<SpaceInternalConditionRelation> spaceInternalConditionRelations = GetRelations<SpaceInternalConditionRelation>(space);
            if (spaceInternalConditionRelations == null)
            {
                return default;
            }

            List<SpaceInternalCondition> result = new List<SpaceInternalCondition>();
            foreach (SpaceInternalConditionRelation spaceInternalConditionRelation in spaceInternalConditionRelations)
            {
                IInternalCondition internalCondition = buildingRelationCluster.GetInternalCondition(spaceInternalConditionRelation);
                if (internalCondition == null)
                {
                    continue;
                }

                result.Add(new SpaceInternalCondition(internalCondition, spaceInternalConditionRelation.HourRange, spaceInternalConditionRelation.Id));
            }

            return result;
        }
        
        public List<ISpace> GetSpaces(IZone zone)
        {
            if(zone == null)
            {
                return null;
            }

            ZoneRelation zoneRelation = GetRelation<ZoneRelation>(zone);
            if(zoneRelation == null)
            {
                return null;
            }

            List<ISpace> spaces = buildingRelationCluster?.GetSpaces(zoneRelation);
            if(spaces == null)
            {
                return null;
            }

            return spaces?.ConvertAll(x => x.Clone<ISpace>());
        }

        public List<ISpace> GetSpaces(IComponent component)
        {
            if (component == null)
            {
                return null;
            }

            SpaceRelation spaceRelation = GetRelation<SpaceRelation>(component);
            if (spaceRelation == null)
            {
                return null;
            }

            List<ISpace> spaces = buildingRelationCluster?.GetSpaces(spaceRelation);
            if (spaces == null)
            {
                return null;
            }

            return spaces?.ConvertAll(x => x.Clone<ISpace>());
        }

        public List<ISpace> GetSpaces(IOpening opening)
        {
            IComponent component = GetComponent<IComponent>(opening);
            if(component == null)
            {
                return null;
            }

            return GetSpaces(component);
        }

        public List<TSpace> GetSpaces<TSpace>(IInternalCondition internalCondition) where TSpace : ISpace
        {
            List<SpaceInternalConditionRelation> spaceInternalConditionRelations = GetRelations<SpaceInternalConditionRelation>(internalCondition);
            if(spaceInternalConditionRelations == null)
            {
                return null;
            }

            List<TSpace> result = new List<TSpace>();
            foreach(SpaceInternalConditionRelation spaceInternalConditionRelation in spaceInternalConditionRelations)
            {
                TSpace space = Core.Query.Clone(buildingRelationCluster.GetSpace<TSpace>(spaceInternalConditionRelation));
                if (space == null)
                {
                    continue;
                }

                result.Add(space);
            }

            return result;
        }

        public List<TSpace> GetSpaces<TSpace>() where TSpace : ISpace
        {
            return buildingRelationCluster.GetSpaces<TSpace>().ConvertAll(x => x.Clone<TSpace>());
        }

        public bool Inside(Geometry.Spatial.Classes.Sphere sphere, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if(sphere == null)
            {
                return false;
            }

            List<IComponent> components = buildingRelationCluster.GetValues<IComponent>();
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

        public bool Remove(IConstruction construction)
        {
            return Remove(construction == null ? null : new GuidReference(construction));
        }

        public bool Remove(ISpace space)
        {
            return Remove(space == null ? null : new GuidReference(space));
        }

        public bool Remove(IComponent component)
        {
            return Remove(component == null ? null : new GuidReference(component));
        }

        public bool Remove(IOpening opening)
        {
            return Remove(opening == null ? null : new GuidReference(opening));
        }

        public bool Remove(IZone zone)
        {
            return Remove(zone == null ? null : new GuidReference(zone));
        }

        public bool Remove(IInternalCondition internalCondition)
        {
            return Remove(internalCondition == null ? null : new GuidReference(internalCondition));
        }

        public bool Remove(IShade shade)
        {
            return Remove(shade == null ? null : new GuidReference(shade));
        }

        public bool Remove(GuidReference guidReference)
        {
            if (guidReference == null)
            {
                return false;
            }

            return buildingRelationCluster.Remove(guidReference);
        }

        public bool TryGetObject<T>(GuidReference guidReference, out T buildingUniqueObject) where T : IBuildingGuidObject
        {
            buildingUniqueObject = default;

            if (guidReference == null || buildingRelationCluster == null)
            {
                return false;
            }

            bool result = buildingRelationCluster.TryGetValue(guidReference, out T buildingUniqueObject_Temp);

            if (result && buildingUniqueObject_Temp != null)
            {
                buildingUniqueObject = buildingUniqueObject_Temp.Clone<T>();
            }

            return result;
        }

        public bool Unassign(IComponent component, ISpace space)
        {
            if (component == null || space == null)
            {
                return false;
            }

            SpaceRelation spaceRelation = GetRelation<SpaceRelation>(component);
            if (spaceRelation == null)
            {
                return false;
            }

            GuidReference guidReference = new GuidReference(space);

            if (!spaceRelation.Remove(RelationSide.To, guidReference))
            {
                return false;
            }

            List<IUniqueReference> uniqueReferences = spaceRelation.UniqueReferences_To;
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                buildingRelationCluster.Remove(spaceRelation);
            }

            return true;
        }

        public bool Unassign(IZone zone, ISpace space)
        {
            if (zone == null || space == null)
            {
                return false;
            }

            ZoneRelation zoneRelation = GetRelation<ZoneRelation>(zone);
            if (zoneRelation == null)
            {
                return false;
            }

            GuidReference guidReference = new GuidReference(space);

            if (!zoneRelation.Remove(RelationSide.To, guidReference))
            {
                return false;
            }

            List<IUniqueReference> uniqueReferences = zoneRelation.UniqueReferences_To;
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                buildingRelationCluster.Remove(zoneRelation);
            }

            return true;
        }

        public bool Unassign(IComponent component, IOpening opening)
        {
            if (component == null || opening == null)
            {
                return false;
            }

            OpeningRelation openingRelation = GetRelation<OpeningRelation>(component);
            if (openingRelation == null)
            {
                return false;
            }

            if (openingRelation.UniqueReferences_To.Count == 1)
            {
                buildingRelationCluster.Remove(openingRelation);
            }
            else
            {
                openingRelation.Remove(RelationSide.To, new GuidReference(opening));
            }

            return true;
        }

        public bool Update(IComponent component)
        {
            if (component == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(component.Clone<IComponent>());
        }

        public bool Update(IConstruction construction)
        {
            if (construction == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(construction.Clone<IConstruction>());
        }

        public bool Update(ISpace space)
        {
            if (space == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(space.Clone<ISpace>());
        }

        public bool Update(IInternalCondition internalCondition)
        {
            if (internalCondition == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(internalCondition.Clone<IInternalCondition>());
        }

        public bool Update(IZone zone)
        {
            if (zone == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(zone.Clone<IZone>());
        }

        public bool Update(IOpening opening)
        {
            if (opening == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(opening.Clone<IOpening>());
        }

        public bool Update(IShade shade)
        {
            if (shade == null)
            {
                return false;
            }

            return buildingRelationCluster.Add(shade.Clone<IShade>());
        }

        private bool Assign(IComponent component, IOpening opening)
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

            GuidReference guidReference = new GuidReference(opening);

            OpeningRelation openingRelation = GetRelation<OpeningRelation>(opening);
            if(openingRelation != null)
            {
                if(openingRelation.UniqueReferences_To.Count == 1)
                {
                    buildingRelationCluster.Remove(openingRelation);
                }
                else
                {
                    openingRelation.Remove(RelationSide.To, guidReference);
                }
            }

            List<IOpening> openings = null;

            openingRelation = GetRelation<OpeningRelation>(component);
            if(openingRelation != null)
            {
                buildingRelationCluster.Remove(openingRelation);

                buildingRelationCluster.TryGetValues(openingRelation.UniqueReferences_To?.FindAll(x => x is GuidReference).Cast<GuidReference>(), out openings);
            }

            if(openings == null)
            {
                openings = new List<IOpening>();
            }

            openings.Add(opening);

            buildingRelationCluster.AddRelation(new OpeningRelation(component, openings));

            return true;
        }

        private T GetConstruction<T>(IComponent component) where T : IConstruction
        {
            if (buildingRelationCluster == null || component == null)
            {
                return default;
            }

            ComponentConstructionRelation componentConstructionRelation = GetRelation<ComponentConstructionRelation>(component);
            if (componentConstructionRelation == null)
            {
                return default;
            }

            IConstruction construction = buildingRelationCluster.GetConstruction(componentConstructionRelation);
            if(construction is T)
            {
                return ((T)construction).Clone<T>();
            }

            return  default;
        }

        private T GetConstruction<T>(IOpening opening) where T : IOpeningConstruction
        {
            if (buildingRelationCluster == null || opening == null)
            {
                return default;
            }

            OpeningConstructionRelation openingConstructionRelation = GetRelation<OpeningConstructionRelation>(opening);
            if (openingConstructionRelation == null)
            {
                return default;
            }

            IOpeningConstruction openingConstruction = buildingRelationCluster.GetOpeningConstruction(openingConstructionRelation);
            if (openingConstruction is T)
            {
                return ((T)openingConstruction).Clone<T>();
            }

            return default;
        }
    }
}
