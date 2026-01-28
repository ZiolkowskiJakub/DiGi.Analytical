using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    public class PhysicalComponentConstructionRelation : OneToOneBidirectionalRelation<IComponent, IPhysicalComponentConstruction>, IBuildingRelation
    {
        public PhysicalComponentConstructionRelation(IComponent? component, IPhysicalComponentConstruction? componentConstruction)
            : base(component, componentConstruction)
        {
        }

        public PhysicalComponentConstructionRelation(PhysicalComponentConstructionRelation? physicalComponentConstructionRelation)
            : base(physicalComponentConstructionRelation)
        {
        }

        public PhysicalComponentConstructionRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}