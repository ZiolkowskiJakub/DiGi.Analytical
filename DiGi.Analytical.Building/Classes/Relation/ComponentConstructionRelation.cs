using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;

namespace DiGi.Analytical.Building.Classes
{
    public class PhysicalComponentConstructionRelation : OneToOneBidirectionalRelation<IComponent, IPhysicalComponentConstruction>, IBuildingRelation
    {
        public PhysicalComponentConstructionRelation(IComponent? component, IPhysicalComponentConstruction? componentConstruction)
            : base(component, componentConstruction)
        {

        }
    }
}
