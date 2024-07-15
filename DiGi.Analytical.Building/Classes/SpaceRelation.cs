using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    public class SpaceRelation : OneToManyBidirectionalRelation, IBuildingRelation
    {
        public SpaceRelation(IComponent component, ISpace space)
            : base(component, new List<ISpace>() { space })
        {

        }

        public SpaceRelation(IComponent component, ISpace space_1, ISpace space_2)
            : base(component, new List<ISpace>() { space_1, space_2 })
        {

        }
    }
}
