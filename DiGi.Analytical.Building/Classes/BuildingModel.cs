﻿using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.Text.Json.Serialization;
using DiGi.Core;
using System.Collections.Generic;
using DiGi.Core.Classes;
using System;

namespace DiGi.Analytical.Building.Classes
{
    public class BuildingModel : UniqueParametrizedObject, IBuildingUniqueObject, IModel
    {
        [JsonInclude, JsonPropertyName("BuildingRelationCluster"), System.ComponentModel.Description("BuildingRelationCluster")]
        private BuildingRelationCluster buildingRelationCluster = new BuildingRelationCluster();

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

            UniqueReference uniqueReference = new UniqueReference(space_2);

            List<SpaceRelation> spaceRelations = GetRelations(space_1, (SpaceRelation x) => x.UniqueReferences_To.Contains(uniqueReference));
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

        public T GetObject<T>(UniqueReference uniqueReference) where T : IBuildingUniqueObject
        {
            if (!TryGetObject<T>(uniqueReference, out T result))
            {
                return result;
            }

            return default;
        }

        public T GetObject<T>(IBuildingRelation buildingRelation) where T : IBuildingUniqueObject
        {
            if (buildingRelation == null || buildingRelationCluster == null)
            {
                return default;
            }

            List<UniqueReference> uniqueReferences = buildingRelation?.UniqueReferences;
            if (uniqueReferences == null)
            {
                return default;
            }

            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if (!buildingRelationCluster.TryGetObject(uniqueReference, out T result))
                {
                    return result.Clone<T>();
                }
            }

            return default;
        }

        public List<T> GetObjects<T>(IBuildingRelation buildingRelation) where T : IBuildingUniqueObject
        {
            if (buildingRelation == null || buildingRelationCluster == null)
            {
                return null;
            }

            List<UniqueReference> uniqueReferences = buildingRelation?.UniqueReferences;
            if (uniqueReferences == null)
            {
                return null;
            }

            if (!buildingRelationCluster.TryGetObjects(uniqueReferences, out List<T> result))
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

            List<UniqueReference> uniqueReferences = openingRelation.UniqueReferences_To;
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                return null;
            }

            if (!buildingRelationCluster.TryGetObjects(uniqueReferences, out List<T> result))
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

            return buildingRelationCluster?.GetObjects(func)?.ConvertAll(x => x.Clone<T>());
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

        public T GetRelation<T>(IBuildingUniqueObject buildingUniqueObject, Func<T, bool> func = null) where T : IBuildingRelation
        {
            if (buildingUniqueObject == null || buildingRelationCluster == null)
            {
                return default;
            }

            UniqueReference uniqueReference = new UniqueReference(buildingUniqueObject);
            if (uniqueReference == null)
            {
                return default;
            }

            if (!buildingRelationCluster.Contains(uniqueReference))
            {
                return default;
            }

            T result = buildingRelationCluster.GetRelation(uniqueReference, func);

            return result == null ? default : result.Clone<T>();
        }

        public List<T> GetRelations<T>(IBuildingUniqueObject buildingUniqueObject, Func<T, bool> func = null) where T : IBuildingRelation
        {
            if (buildingUniqueObject == null || buildingRelationCluster == null)
            {
                return null;
            }

            UniqueReference uniqueReference = new UniqueReference(buildingUniqueObject);
            if (uniqueReference == null)
            {
                return null;
            }

            if (!buildingRelationCluster.Contains(uniqueReference))
            {
                return null;
            }

            return buildingRelationCluster.GetRelations(uniqueReference, func)?.ConvertAll(x => x.Clone<T>());
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

        public bool Remove(IConstruction construction)
        {
            return Remove(construction == null ? null : new UniqueReference(construction));
        }

        public bool Remove(ISpace space)
        {
            return Remove(space == null ? null : new UniqueReference(space));
        }

        public bool Remove(IComponent component)
        {
            return Remove(component == null ? null : new UniqueReference(component));
        }

        public bool Remove(IOpening opening)
        {
            return Remove(opening == null ? null : new UniqueReference(opening));
        }

        public bool Remove(IZone zone)
        {
            return Remove(zone == null ? null : new UniqueReference(zone));
        }

        public bool Remove(UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            return buildingRelationCluster.Remove(uniqueReference);
        }

        public bool TryGetObject<T>(UniqueReference uniqueReference, out T buildingUniqueObject) where T : IBuildingUniqueObject
        {
            buildingUniqueObject = default;

            if (uniqueReference == null || buildingRelationCluster == null)
            {
                return false;
            }

            bool result = buildingRelationCluster.TryGetObject(uniqueReference, out T buildingUniqueObject_Temp);

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

            UniqueReference uniqueReference = new UniqueReference(space);

            if (!spaceRelation.Remove_To(uniqueReference))
            {
                return false;
            }

            List<UniqueReference> uniqueReferences = spaceRelation.UniqueReferences_To;
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

            UniqueReference uniqueReference = new UniqueReference(space);

            if (!zoneRelation.Remove_To(uniqueReference))
            {
                return false;
            }

            List<UniqueReference> uniqueReferences = zoneRelation.UniqueReferences_To;
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
                openingRelation.Remove_To(new UniqueReference(opening));
            }

            return true;
        }

        public bool Update(IComponent component)
        {
            if (component == null)
            {
                return false;
            }

            return buildingRelationCluster.Update(component.Clone<IComponent>());
        }

        public bool Update(IConstruction construction)
        {
            if (construction == null)
            {
                return false;
            }

            return buildingRelationCluster.Update(construction.Clone<IConstruction>());
        }

        public bool Update(ISpace space)
        {
            if (space == null)
            {
                return false;
            }

            return buildingRelationCluster.Update(space.Clone<ISpace>());
        }

        public bool Update(IZone zone)
        {
            if (zone == null)
            {
                return false;
            }

            return buildingRelationCluster.Update(zone.Clone<IZone>());
        }

        public bool Update(IOpening opening)
        {
            if (opening == null)
            {
                return false;
            }

            return buildingRelationCluster.Update(opening.Clone<IOpening>());
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

            UniqueReference uniqueReference = new UniqueReference(opening);

            OpeningRelation openingRelation = GetRelation<OpeningRelation>(opening);
            if(openingRelation != null)
            {
                if(openingRelation.UniqueReferences_To.Count == 1)
                {
                    buildingRelationCluster.Remove(openingRelation);
                }
                else
                {
                    openingRelation.Remove_To(uniqueReference);
                }
            }

            List<IOpening> openings = null;

            openingRelation = GetRelation<OpeningRelation>(component);
            if(openingRelation != null)
            {
                buildingRelationCluster.Remove(openingRelation);

                buildingRelationCluster.TryGetObjects(openingRelation.UniqueReferences_To, out openings);
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
