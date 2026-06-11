using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Relation.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents a one-to-one bidirectional relation between a component and its physical component construction.
    /// </summary>
    public class PhysicalComponentConstructionRelation : OneToOneBidirectionalRelation<IComponent, IPhysicalComponentConstruction>, IBuildingRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstructionRelation"/> class.
        /// </summary>
        /// <param name="component">The component associated with this relation.</param>
        /// <param name="componentConstruction">The physical component construction associated with this relation.</param>
        public PhysicalComponentConstructionRelation(IComponent? component, IPhysicalComponentConstruction? componentConstruction)
            : base(component, componentConstruction)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstructionRelation"/> class based on an existing relation instance.
        /// </summary>
        /// <param name="physicalComponentConstructionRelation">The existing <see cref="PhysicalComponentConstructionRelation"/> instance to copy from.</param>
        public PhysicalComponentConstructionRelation(PhysicalComponentConstructionRelation? physicalComponentConstructionRelation)
            : base(physicalComponentConstructionRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstructionRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object from which to initialize the relation.</param>
        public PhysicalComponentConstructionRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}