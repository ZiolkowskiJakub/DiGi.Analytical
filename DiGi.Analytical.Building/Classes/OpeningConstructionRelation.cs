﻿using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;

namespace DiGi.Analytical.Building.Classes
{
    public class OpeningConstructionRelation : OneToOneBidirectionalRelation, IBuildingRelation
    {
        public OpeningConstructionRelation(IOpening opening, IOpeningConstruction openingConstruction)
            : base(opening, openingConstruction)
        {

        }
    }
}
