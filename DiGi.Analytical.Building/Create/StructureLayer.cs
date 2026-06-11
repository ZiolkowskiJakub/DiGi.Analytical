using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Analytical.Interfaces;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        /// <summary>
        /// Creates and adds a new <see cref="T:DiGi.Analytical.Building.Classes.StructureLayer"/> to the specified construction relation cluster.
        /// </summary>
        /// <param name="constructionRelationCluster">The construction relation cluster where the structure layer will be created and stored.</param>
        /// <param name="physicalComponentConstruction">The physical component construction associated with the structure layer.</param>
        /// <param name="material">The material to be assigned to the structure layer.</param>
        /// <param name="thickness">The thickness of the structure layer.</param>
        /// <returns>A new <see cref="T:DiGi.Analytical.Building.Classes.StructureLayer"/> instance if successfully created and added; otherwise, <c>null</c>.</returns>
        public static StructureLayer? StructureLayer(this ConstructionRelationCluster? constructionRelationCluster, IPhysicalComponentConstruction? physicalComponentConstruction, IMaterial? material, double thickness)
        {
            if (constructionRelationCluster is null || physicalComponentConstruction is null || material is null || double.IsNaN(thickness))
            {
                return null;
            }

            if (!constructionRelationCluster.Contains(new Core.Classes.GuidReference(physicalComponentConstruction)) || !constructionRelationCluster.Contains(new Core.Classes.GuidReference(material)))
            {
                return null;
            }

            int index = Query.NextStructureLayerIndex(constructionRelationCluster, physicalComponentConstruction);
            if (index == -1)
            {
                return null;
            }

            StructureLayer result = new(index, thickness);
            if (!constructionRelationCluster.Add(result))
            {
                return null;
            }

            PhysicalComponentConstructionStructureLayersRelation? componentConstructionStructureLayersRelation = constructionRelationCluster.AddRelation(physicalComponentConstruction, result);
            if (componentConstructionStructureLayersRelation is null)
            {
                return null;
            }

            MaterialStructureLayerRelation? materialStructureLayerRelation = constructionRelationCluster.AddRelation(material, result);
            if (materialStructureLayerRelation is null)
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Creates a new structure layer and associates it with an opening construction part and a material within the specified relation cluster.
        /// </summary>
        /// <param name="constructionRelationCluster">The construction relation cluster to which the structure layer and its relations are added.</param>
        /// <param name="openinigConstruction">The opening construction associated with the new structure layer.</param>
        /// <param name="openingConstructionPart">The specific part of the opening construction for the structure layer.</param>
        /// <param name="material">The material to be assigned to the structure layer.</param>
        /// <param name="thickness">The thickness of the structure layer.</param>
        /// <returns>The created <see cref="T:DiGi.Analytical.Building.Classes.StructureLayer"/> if successful; otherwise, <c>null</c>.</returns>
        public static StructureLayer? StructureLayer(this ConstructionRelationCluster? constructionRelationCluster, IOpeningConstruction? openinigConstruction, OpeningConstructionPart openingConstructionPart, IMaterial? material, double thickness)
        {
            if (constructionRelationCluster is null || openinigConstruction is null || material is null || double.IsNaN(thickness))
            {
                return null;
            }

            if (!constructionRelationCluster.Contains(new Core.Classes.GuidReference(openinigConstruction)) || !constructionRelationCluster.Contains(new Core.Classes.GuidReference(material)))
            {
                return null;
            }

            int index = Query.NextStructureLayerIndex(constructionRelationCluster, openinigConstruction, openingConstructionPart);
            if (index == -1)
            {
                return null;
            }

            StructureLayer result = new(index, thickness);

            OpeningConstructionStructureLayersRelation? openingConstructionStructureLayersRelation = constructionRelationCluster.AddRelation(openinigConstruction, openingConstructionPart, result);
            if (openingConstructionStructureLayersRelation is null)
            {
                return null;
            }

            MaterialStructureLayerRelation? materialStructureLayerRelation = constructionRelationCluster.AddRelation(material, result);
            if (materialStructureLayerRelation is null)
            {
                return null;
            }

            return result;
        }
    }
}
