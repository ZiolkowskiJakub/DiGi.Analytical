using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.Text.Json.Serialization;
using DiGi.Core;
using System.Collections.Generic;
using DiGi.Core.Classes;
using System;
using System.Net.Http.Headers;

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

        public bool Unassign(IComponent component, ISpace space)
        {
            if(component == null || space == null)
            {
                return false;
            }
            
            SpaceRelation spaceRelation = GetRelation<SpaceRelation>(component);
            if (spaceRelation == null)
            {
                return false;
            }

            UniqueReference uniqueReference = new UniqueReference(space);

            if(!spaceRelation.Remove_To(uniqueReference))
            {
                return false;
            }

            List<UniqueReference> uniqueReferences = spaceRelation.UniqueReferences_To;
            if(uniqueReferences == null || uniqueReferences.Count == 0)
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

        public List<T> GetComponents<T>(IConstruction construction) where T : IComponent
        {
            if (buildingRelationCluster == null || construction == null)
            {
                return null;
            }

            List<ComponentConstructionRelation> constructionRelations = GetRelations<ComponentConstructionRelation>(construction);
            if (constructionRelations == null)
            {
                return default;
            }

            List<T> result = new List<T>();
            foreach (ComponentConstructionRelation constructionRelation in constructionRelations)
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

        public bool Update(IComponent component)
        {
            if(component == null)
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

        public bool Remove(IZone zone)
        {
            return Remove(zone == null ? null : new UniqueReference(zone));
        }

        public bool Remove(UniqueReference uniqueReference)
        {
            if(uniqueReference == null)
            {
                return false;
            }

            return buildingRelationCluster.Remove(uniqueReference);
        }
    }
}
