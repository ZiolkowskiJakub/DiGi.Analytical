using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a bidirectional one-to-many relationship between a building component and its associated openings.
    /// </summary>
    public class OpeningRelation : OneToManyBidirectionalRelation<IComponent, IOpening>, IBuildingRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningRelation"/> class with the specified component and opening.
        /// </summary>
        /// <param name="component">The component associated with this relation.</param>
        /// <param name="opening">The opening associated with this relation.</param>
        public OpeningRelation(IComponent? component, IOpening? opening)
            : base(component, Core.Query.CloneAndFilterNulls([opening]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningRelation"/> class using the specified component and collection of openings.
        /// </summary>
        /// <param name="component">The component associated with this opening relation.</param>
        /// <param name="openings">The collection of openings associated with this opening relation.</param>
        public OpeningRelation(IComponent? component, IEnumerable<IOpening>? openings)
            : base(component, openings)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningRelation"/> class by copying an existing relation.
        /// </summary>
        /// <param name="openingRelation">The source <see cref="OpeningRelation"/> instance to copy from.</param>
        public OpeningRelation(OpeningRelation? openingRelation)
            : base(openingRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningRelation"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the serialized data used to populate the relation.</param>
        public OpeningRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}