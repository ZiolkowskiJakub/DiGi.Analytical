using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;

namespace DiGi.Analytical.Building.Classes
{
    public class ConstructionRelation : OneToOneBidirectionalRelation, IBuildingRelation
    {
        public ConstructionRelation(IComponent component, IConstruction construction)
            : base(component, construction)
        {

        }
    }
}
