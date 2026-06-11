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
        /// <summary>
        /// Calculates the next structure layer index for a specified physical component construction within the provided construction relation cluster.
        /// </summary>
        /// <param name="constructionRelationCluster">The construction relation cluster used to retrieve relations and structure layers.</param>
        /// <param name="physicalComponentConstruction">The physical component construction for which the next structure layer index is determined.</param>
        /// <returns>The maximum structure layer index found; 0 if no associated structure layers exist; or -1 if either the <paramref name="constructionRelationCluster"/> or <paramref name="physicalComponentConstruction"/> is null.</returns>
        public static int NextStructureLayerIndex(this ConstructionRelationCluster? constructionRelationCluster, IPhysicalComponentConstruction? physicalComponentConstruction)
        {
            if (constructionRelationCluster is null || physicalComponentConstruction is null)
            {
                return -1;
            }

            PhysicalComponentConstructionStructureLayersRelation? componentConstructionStructureLayersRelation = constructionRelationCluster.GetRelation<PhysicalComponentConstructionStructureLayersRelation>(physicalComponentConstruction);
            if (componentConstructionStructureLayersRelation is null)
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

        /// <summary>
        /// Calculates the next available structure layer index for a specific part of an opening construction.
        /// </summary>
        /// <param name="constructionRelationCluster">The relation cluster used to retrieve the structure layer relations.</param>
        /// <param name="openingConstruction">The opening construction instance.</param>
        /// <param name="openingConstructionPart">The part of the opening construction (e.g., pane or frame) for which the index is calculated.</param>
        /// <returns>The next available structure layer index; 0 if no relations are found, or -1 if any input parameter is null or undefined.</returns>
        public static int NextStructureLayerIndex(this ConstructionRelationCluster? constructionRelationCluster, IOpeningConstruction? openingConstruction, OpeningConstructionPart openingConstructionPart)
        {
            if (constructionRelationCluster is null || openingConstruction is null || openingConstructionPart == OpeningConstructionPart.Undefined)
            {
                return -1;
            }

            OpeningConstructionStructureLayersRelation? openingConstructionStructureLayersRelation = null;

            if (openingConstructionPart == OpeningConstructionPart.Pane)
            {
                openingConstructionStructureLayersRelation = constructionRelationCluster.GetRelation<PaneOpeningConstructionStructureLayersRelation>(openingConstruction);
            }
            else if (openingConstructionPart == OpeningConstructionPart.Frame)
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