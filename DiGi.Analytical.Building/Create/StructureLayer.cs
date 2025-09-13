using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Classes;
using DiGi.Analytical.Interfaces;

namespace DiGi.Analytical.Building
{
    public static partial class Create
    {
        public static StructureLayer? StructureLayer(this ConstructionRelationCluster? constructionRelationCluster, IComponentConstruction? componentConstruction, IMaterial? material, double thickness)
        {
            if(constructionRelationCluster is null || componentConstruction is null || material is null || double.IsNaN(thickness))
            {
                return null;
            }

            if(!constructionRelationCluster.Contains(new Core.Classes.GuidReference(componentConstruction)) || !constructionRelationCluster.Contains(new Core.Classes.GuidReference(material)))
            {
                return null;
            }

            int index = Query.NextStructureLayerIndex(constructionRelationCluster, componentConstruction);
            if(index == -1)
            {
                return null;
            }

            StructureLayer result = new (index, thickness);
            if(!constructionRelationCluster.Add(result))
            {
                return null;
            }

            ComponentConstructionStructureLayersRelation? componentConstructionStructureLayersRelation = constructionRelationCluster.AddRelation(componentConstruction, result);
            if(componentConstructionStructureLayersRelation is null)
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
