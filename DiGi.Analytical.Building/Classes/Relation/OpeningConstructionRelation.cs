using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a one-to-one bidirectional relation between an opening and an opening construction.
    /// </summary>
    public class OpeningConstructionRelation : OneToOneBidirectionalRelation<IOpening, IOpeningConstruction>, IBuildingRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstructionRelation"/> class.
        /// </summary>
        /// <param name="opening">The opening associated with this relation.</param>
        /// <param name="openingConstruction">The opening construction associated with this relation.</param>
        public OpeningConstructionRelation(IOpening? opening, IOpeningConstruction? openingConstruction)
            : base(opening, openingConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstructionRelation"/> class based on an existing relation instance.
        /// </summary>
        /// <param name="openingConstructionRelation">The existing <see cref="OpeningConstructionRelation"/> instance to copy from.</param>
        public OpeningConstructionRelation(OpeningConstructionRelation? openingConstructionRelation)
            : base(openingConstructionRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningConstructionRelation"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the serialized data used to initialize the relation.</param>
        public OpeningConstructionRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}