using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Analytical.Building
{
    public static partial class Query
    {
        public static int NextStructureLayerIndex(this ConstructionRelationCluster? constructionRelationCluster, IPhysicalComponentConstruction? physicalComponentConstruction)
        {
            if(constructionRelationCluster is null || physicalComponentConstruction is null)
            {
                return -1;
            }

            PhysicalComponentConstructionStructureLayersRelation? componentConstructionStructureLayersRelation = constructionRelationCluster.GetRelation<PhysicalComponentConstructionStructureLayersRelation>(physicalComponentConstruction);
            if(componentConstructionStructureLayersRelation is null)
            {
                return 0;
            }

            if (componentConstructionStructureLayersRelation.UniqueReferences_To is not List<IUniqueReference> uniqueReferences || uniqueReferences.Count == 0) 
            {
                return 0;
            }

            int result = 0;

            foreach (IUniqueReference uniqueReference in uniqueReferences) 
            { 
                if(uniqueReference is GuidReference guidReference && constructionRelationCluster.TryGetValue(guidReference, out IStructureLayer? structureLayer) && structureLayer is not null)
                {
                    if(structureLayer.Index > result)
                    {
                        result = structureLayer.Index;
                    }
                }
            }

            result++;

            return result;
        }

        public static int NextStructureLayerIndex(this ConstructionRelationCluster? constructionRelationCluster, IOpeningConstruction? openingConstruction, OpeningConstructionPart openingConstructionPart)
        {
            if (constructionRelationCluster is null || openingConstruction is null || openingConstructionPart == OpeningConstructionPart.Undefined)
            {
                return -1;
            }

            OpeningConstructionStructureLayersRelation? openingConstructionStructureLayersRelation = null;

            if(openingConstructionPart == OpeningConstructionPart.Pane)
            {
                openingConstructionStructureLayersRelation = constructionRelationCluster.GetRelation<PaneOpeningConstructionStructureLayersRelation>(openingConstruction);
            }
            else if(openingConstructionPart == OpeningConstructionPart.Frame)
            {
                openingConstructionStructureLayersRelation = constructionRelationCluster.GetRelation<FrameOpeningConstructionStructureLayersRelation>(openingConstruction);
            }
            else
            {
                return -1;
            }
  
            if (openingConstructionStructureLayersRelation is null)
            {
                return 0;
            }

            if (openingConstructionStructureLayersRelation.UniqueReferences_To is not List<IUniqueReference> uniqueReferences || uniqueReferences.Count == 0)
            {
                return 0;
            }

            int result = 0;

            foreach (IUniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is GuidReference guidReference && constructionRelationCluster.TryGetValue(guidReference, out IStructureLayer? structureLayer) && structureLayer is not null)
                {
                    if (structureLayer.Index > result)
                    {
                        result = structureLayer.Index;
                    }
                }
            }

            result++;

            return result;
        }
    }
}