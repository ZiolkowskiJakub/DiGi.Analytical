using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;

namespace DiGi.Analytical.Building.Classes
{
    public class ComponentConstructionRelation : OneToOneBidirectionalRelation, IBuildingRelation
    {
        public ComponentConstructionRelation(IComponent component, IComponentConstruction componentConstruction)
            : base(component, componentConstruction)
        {

        }
    }
}
