using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;

namespace DiGi.Analytical.Building.Classes
{
    public class SpaceInternalConditionRelation : OneToOneBidirectionalRelation<ISpace, IInternalCondition>, IBuildingRelation
    {
        public SpaceInternalConditionRelation(ISpace space, IInternalCondition internalCondition)
            : base(space, internalCondition)
        {

        }
    }
}
