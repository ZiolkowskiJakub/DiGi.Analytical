using DiGi.Analytical.Building.Enums;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Interfaces;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a cluster of unique object relations that manages the associations between analytical GUID objects and building relations within a construction context.
    /// </summary>
    public class ConstructionRelationCluster : UniqueObjectRelationCluster<IAnalyticalGuidObject, IBuildingRelation>, IBuildingObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionRelationCluster"/> class.
        /// </summary>
        public ConstructionRelationCluster()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionRelationCluster"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data used to initialize the cluster. This value can be null.</param>
        public ConstructionRelationCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionRelationCluster"/> class using another <see cref="ConstructionRelationCluster"/> instance.
        /// </summary>
        /// <param name="constructionRelationCluster">The source <see cref="ConstructionRelationCluster"/> instance to copy from.</param>
        public ConstructionRelationCluster(ConstructionRelationCluster? constructionRelationCluster)
            : base(constructionRelationCluster)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionRelationCluster"/> class using a collection of analytical GUID objects.
        /// </summary>
        /// <param name="analyticalGuidObjects">The collection of analytical GUID objects to initialize the cluster with. This value can be null.</param>
        public ConstructionRelationCluster(IEnumerable<IAnalyticalGuidObject>? analyticalGuidObjects)
            : base(analyticalGuidObjects)
        {
        }

        /// <summary>
        /// Adds or updates a relation between a physical component construction and a structure layer within the construction relation cluster.
        /// </summary>
        /// <param name="physicalComponentConstruction">The physical component construction object to be related.</param>
        /// <param name="structureLayer">The structure layer object to be related.</param>
        /// <returns>The created or updated <see cref="PhysicalComponentConstructionStructureLayersRelation"/>, or <see langword="null"/> if either the <paramref name="physicalComponentConstruction"/> or <paramref name="structureLayer"/> is null.</returns>
        public PhysicalComponentConstructionStructureLayersRelation? AddRelation(IPhysicalComponentConstruction? physicalComponentConstruction, IStructureLayer? structureLayer)
        {
            if (physicalComponentConstruction is null || structureLayer is null)
            {
                return null;
            }

            PhysicalComponentConstructionStructureLayersRelation? componentConstructionStructureLayersRelation = GetRelation<PhysicalComponentConstructionStructureLayersRelation>(new GuidReference(physicalComponentConstruction));
            if (componentConstructionStructureLayersRelation != null)
            {
                Remove(componentConstructionStructureLayersRelation);
                componentConstructionStructureLayersRelation.Add(Core.Relation.Enums.RelationSide.To, new GuidReference(structureLayer));
            }
            else
            {
                componentConstructionStructureLayersRelation = new PhysicalComponentConstructionStructureLayersRelation(physicalComponentConstruction, structureLayer);
            }

            return AddRelation(componentConstructionStructureLayersRelation);
        }

        /// <summary>
        /// Adds a relation between an opening construction and a structure layer based on the specified construction part.
        /// </summary>
        /// <param name="openingConstruction">The opening construction object involved in the relation.</param>
        /// <param name="openingConstructionPart">The specific part of the opening construction to relate.</param>
        /// <param name="structureLayer">The structure layer object involved in the relation.</param>
        /// <returns>The created or updated <see cref="OpeningConstructionStructureLayersRelation"/>, or <c>null</c> if any input is null or the part is undefined.</returns>
        public OpeningConstructionStructureLayersRelation? AddRelation(IOpeningConstruction? openingConstruction, OpeningConstructionPart openingConstructionPart, IStructureLayer? structureLayer)
        {
            if (openingConstruction is null || structureLayer is null || openingConstructionPart == OpeningConstructionPart.Undefined)
            {
                return null;
            }

            if (openingConstructionPart == OpeningConstructionPart.Pane)
            {
                PaneOpeningConstructionStructureLayersRelation? paneOpeningConstructionStructureLayersRelation = GetRelation<PaneOpeningConstructionStructureLayersRelation>(new GuidReference(openingConstruction));
                if (paneOpeningConstructionStructureLayersRelation != null)
                {
                    Remove(paneOpeningConstructionStructureLayersRelation);
                    paneOpeningConstructionStructureLayersRelation.Add(Core.Relation.Enums.RelationSide.To, new GuidReference(structureLayer));
                }
                else
                {
                    paneOpeningConstructionStructureLayersRelation = new PaneOpeningConstructionStructureLayersRelation(openingConstruction, structureLayer);
                }

                return AddRelation(paneOpeningConstructionStructureLayersRelation);
            }
            else if (openingConstructionPart == OpeningConstructionPart.Frame)
            {
                FrameOpeningConstructionStructureLayersRelation? frameOpeningConstructionStructureLayersRelation = GetRelation<FrameOpeningConstructionStructureLayersRelation>(new GuidReference(openingConstruction));
                if (frameOpeningConstructionStructureLayersRelation != null)
                {
                    Remove(frameOpeningConstructionStructureLayersRelation);
                    frameOpeningConstructionStructureLayersRelation.Add(Core.Relation.Enums.RelationSide.To, new GuidReference(structureLayer));
                }
                else
                {
                    frameOpeningConstructionStructureLayersRelation = new FrameOpeningConstructionStructureLayersRelation(openingConstruction, structureLayer);
                }

                return AddRelation(frameOpeningConstructionStructureLayersRelation);
            }

            return null;
        }

        /// <summary>
        /// Adds a relation between the specified material and structure layer.
        /// </summary>
        /// <param name="material">The material to be associated with the structure layer.</param>
        /// <param name="structureLayer">The structure layer to be associated with the material.</param>
        /// <returns>The created <see cref="MaterialStructureLayerRelation"/> if successful; otherwise, <c>null</c>.</returns>
        public MaterialStructureLayerRelation? AddRelation(IMaterial? material, IStructureLayer? structureLayer)
        {
            if (material is null || structureLayer is null)
            {
                return null;
            }

            return AddRelation(new MaterialStructureLayerRelation(material, structureLayer));
        }

        /// <summary>
        /// Retrieves the material associated with the specified structure layer.
        /// </summary>
        /// <param name="structureLayer">The structure layer for which to retrieve the associated material.</param>
        /// <returns>The <see cref="IMaterial"/> associated with the provided structure layer, or <c>null</c> if no relation exists or the <paramref name="structureLayer"/> is null.</returns>
        public IMaterial? GetMaterial(IStructureLayer? structureLayer)
        {
            if (structureLayer is null)
            {
                return null;
            }

            MaterialStructureLayerRelation? materialStructureLayerRelation = GetRelation<MaterialStructureLayerRelation>(structureLayer);
            if (materialStructureLayerRelation is null)
            {
                return null;
            }

            if (materialStructureLayerRelation.UniqueReference_From is not GuidReference guidReference || !TryGetValue(guidReference, out IMaterial? result))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the list of structure layers associated with the specified physical component construction.
        /// </summary>
        /// <param name="physicalComponentConstruction">The physical component construction for which to retrieve the associated structure layers.</param>
        /// <returns>A list of <see cref="IStructureLayer"/> objects if found; otherwise, null.</returns>
        public List<IStructureLayer>? GetStructureLayers(IPhysicalComponentConstruction? physicalComponentConstruction)
        {
            if (physicalComponentConstruction is null)
            {
                return null;
            }

            PhysicalComponentConstructionStructureLayersRelation? componentConstructionStructureLayersRelation = GetRelation<PhysicalComponentConstructionStructureLayersRelation>(new GuidReference(physicalComponentConstruction));
            if (componentConstructionStructureLayersRelation is null)
            {
                return null;
            }

            if (componentConstructionStructureLayersRelation.UniqueReferences_To is not List<IUniqueReference> uniqueReferences)
            {
                return null;
            }

            List<IStructureLayer> result = [];
            foreach (IUniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is not GuidReference guidReference || !TryGetValue(guidReference, out IStructureLayer? structureLayer) || structureLayer is null)
                {
                    continue;
                }

                result.Add(structureLayer);
            }

            return result;
        }
    }
}