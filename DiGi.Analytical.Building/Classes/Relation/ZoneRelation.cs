using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class ZoneRelation : OneToManyBidirectionalRelation<IZone, ISpace>, IBuildingRelation
    {
        public ZoneRelation(IZone? zone, ISpace? space)
            : base(zone, Core.Query.CloneAndFilterNulls([space]))
        {

        }

        public ZoneRelation(IZone? zone, IEnumerable<ISpace>? spaces)
            : base(zone, spaces)
        {

        }

        public ZoneRelation(ZoneRelation? zoneRelation)
            : base(zoneRelation)
        {

        }

        public ZoneRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }
    }
}
