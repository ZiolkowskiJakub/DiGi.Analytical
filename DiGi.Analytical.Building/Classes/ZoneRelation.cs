using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Classes
{
    public class ZoneRelation : OneToManyBidirectionalRelation, IBuildingRelation
    {
        public ZoneRelation(IZone zone, ISpace space)
            : base(zone, new List<ISpace>() { space })
        {

        }

        public ZoneRelation(IZone zone, IEnumerable<ISpace> spaces)
            : base(zone, spaces)
        {

        }
    }
}
