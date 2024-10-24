using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    public class OpeningRelation : OneToManyBidirectionalRelation<IComponent, IOpening>, IBuildingRelation
    {
        public OpeningRelation(IComponent component, IOpening opening)
            : base(component, new List<IOpening>() { opening })
        {

        }

        public OpeningRelation(IComponent component, IEnumerable<IOpening> openings)
            : base(component, openings)
        {

        }
    }
}
