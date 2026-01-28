using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class OpeningConstructionRelation : OneToOneBidirectionalRelation<IOpening, IOpeningConstruction>, IBuildingRelation
    {
        public OpeningConstructionRelation(IOpening? opening, IOpeningConstruction? openingConstruction)
            : base(opening, openingConstruction)
        {
        }

        public OpeningConstructionRelation(OpeningConstructionRelation? openingConstructionRelation)
            : base(openingConstructionRelation)
        {
        }

        public OpeningConstructionRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}