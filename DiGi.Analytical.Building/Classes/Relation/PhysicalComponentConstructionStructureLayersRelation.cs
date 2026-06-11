using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the relationship between a physical component construction and one or more structure layers.
    /// </summary>
    public class PhysicalComponentConstructionStructureLayersRelation : ConstructionStructureLayersRelation<IPhysicalComponentConstruction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstructionStructureLayersRelation"/> class.
        /// </summary>
        /// <param name="physicalComponentConstruction">The physical component construction associated with this relation.</param>
        /// <param name="structureLayer">The structure layer associated with this relation.</param>
        public PhysicalComponentConstructionStructureLayersRelation(IPhysicalComponentConstruction? physicalComponentConstruction, IStructureLayer? structureLayer)
            : base(physicalComponentConstruction, structureLayer)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstructionStructureLayersRelation"/> class using a physical component construction and a collection of structure layers.
        /// </summary>
        /// <param name="physicalComponentConstruction">The physical component construction to be associated with this relation.</param>
        /// <param name="structureLayers">The collection of structure layers to be associated with this relation.</param>
        public PhysicalComponentConstructionStructureLayersRelation(IPhysicalComponentConstruction? physicalComponentConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(physicalComponentConstruction, structureLayers)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstructionStructureLayersRelation"/> class based on an existing relation.
        /// </summary>
        /// <param name="physicalComponentConstructionStructureLayersRelation">The source relation instance to copy.</param>
        public PhysicalComponentConstructionStructureLayersRelation(PhysicalComponentConstructionStructureLayersRelation? physicalComponentConstructionStructureLayersRelation)
            : base(physicalComponentConstructionStructureLayersRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalComponentConstructionStructureLayersRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object from which to initialize the relation.</param>
        public PhysicalComponentConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}