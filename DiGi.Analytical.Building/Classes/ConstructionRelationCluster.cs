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
    public class ConstructionRelationCluster : UniqueObjectRelationCluster<IAnalyticalGuidObject, IBuildingRelation>, IBuildingObject
    {
        public ConstructionRelationCluster()
            : base()
        {
        }

        public ConstructionRelationCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public ConstructionRelationCluster(ConstructionRelationCluster? constructionRelationCluster)
            : base(constructionRelationCluster)
        {
        }

        public ConstructionRelationCluster(IEnumerable<IAnalyticalGuidObject>? analyticalGuidObjects)
            : base(analyticalGuidObjects)
        {
        }

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

        public MaterialStructureLayerRelation? AddRelation(IMaterial? material, IStructureLayer? structureLayer)
        {
            if (material is null || structureLayer is null)
            {
                return null;
            }

            return AddRelation(new MaterialStructureLayerRelation(material, structureLayer));
        }

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