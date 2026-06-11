using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a one-to-many bidirectional relationship between a zone and its associated spaces within a building.
    /// </summary>
    public class ZoneRelation : OneToManyBidirectionalRelation<IZone, ISpace>, IBuildingRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneRelation"/> class that relates a specific zone to a single space.
        /// </summary>
        /// <param name="zone">The zone associated with this relation. This value can be null.</param>
        /// <param name="space">The space associated with this relation. This value can be null.</param>
        public ZoneRelation(IZone? zone, ISpace? space)
            : base(zone, Core.Query.CloneAndFilterNulls([space]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneRelation"/> class with the specified zone and collection of spaces.
        /// </summary>
        /// <param name="zone">The zone associated with this relation. This value can be null.</param>
        /// <param name="spaces">A collection of spaces associated with this relation. This value can be null.</param>
        public ZoneRelation(IZone? zone, IEnumerable<ISpace>? spaces)
            : base(zone, spaces)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneRelation"/> class by copying an existing relation.
        /// </summary>
        /// <param name="zoneRelation">The source <see cref="ZoneRelation"/> instance to copy from.</param>
        public ZoneRelation(ZoneRelation? zoneRelation)
            : base(zoneRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneRelation"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the serialized data used to populate the relation.</param>
        public ZoneRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}