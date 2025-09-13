using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Interfaces;
using DiGi.Core.Relation.Classes;

namespace DiGi.Analytical.Building.Classes
{
    public class MaterialStructureLayerRelation : OneToOneBidirectionalRelation<IMaterial, IStructureLayer>, IBuildingRelation
    {
        public MaterialStructureLayerRelation(IMaterial? material, IStructureLayer? structureLayer)
            : base(material, structureLayer)
        {

        }
    }
}
