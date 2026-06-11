using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the relationship between a pane opening construction and its associated structure layers.
    /// </summary>
    public class PaneOpeningConstructionStructureLayersRelation : OpeningConstructionStructureLayersRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaneOpeningConstructionStructureLayersRelation"/> class using the specified opening construction and structure layer.
        /// </summary>
        /// <param name="openingConstruction">The opening construction associated with this relation.</param>
        /// <param name="structureLayer">The structure layer associated with this relation.</param>
        public PaneOpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IStructureLayer? structureLayer)
            : base(openingConstruction, Core.Query.CloneAndFilterNulls([structureLayer]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaneOpeningConstructionStructureLayersRelation"/> class using the specified opening construction and structure layers.
        /// </summary>
        /// <param name="openingConstruction">The opening construction associated with this relation.</param>
        /// <param name="structureLayers">The collection of structure layers associated with this relation.</param>
        public PaneOpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(openingConstruction, structureLayers)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaneOpeningConstructionStructureLayersRelation"/> class using an existing instance.
        /// </summary>
        /// <param name="paneOpeningConstructionStructureLayersRelation">The source relation instance to copy.</param>
        public PaneOpeningConstructionStructureLayersRelation(PaneOpeningConstructionStructureLayersRelation? paneOpeningConstructionStructureLayersRelation)
            : base(paneOpeningConstructionStructureLayersRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaneOpeningConstructionStructureLayersRelation"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object from which to initialize the relation.</param>
        public PaneOpeningConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}