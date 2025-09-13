using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;

namespace DiGi.Analytical.Building.Classes
{
    public class OpeningConstructionRelation(IOpening? opening, IOpeningConstruction? openingConstruction) : OneToOneBidirectionalRelation<IOpening, IOpeningConstruction>(opening, openingConstruction), IBuildingRelation
    {
    }
}
