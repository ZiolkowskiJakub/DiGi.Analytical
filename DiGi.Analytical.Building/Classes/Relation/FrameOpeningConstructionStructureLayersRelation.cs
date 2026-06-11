using DiGi.Analytical.Building.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Analytical.Building.Classes
{
    /// <summary>
    /// Represents the relation between a frame opening construction and its associated structure layers.
    /// </summary>
    public class FrameOpeningConstructionStructureLayersRelation : OpeningConstructionStructureLayersRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrameOpeningConstructionStructureLayersRelation"/> class.
        /// </summary>
        /// <param name="openingConstruction">The opening construction associated with this relation.</param>
        /// <param name="structureLayer">The structure layer associated with this relation.</param>
        public FrameOpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IStructureLayer? structureLayer)
            : base(openingConstruction, Core.Query.CloneAndFilterNulls([structureLayer]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameOpeningConstructionStructureLayersRelation"/> class.
        /// </summary>
        /// <param name="openingConstruction">The opening construction associated with this relation.</param>
        /// <param name="structureLayers">The collection of structure layers associated with this relation.</param>
        public FrameOpeningConstructionStructureLayersRelation(IOpeningConstruction? openingConstruction, IEnumerable<IStructureLayer>? structureLayers)
            : base(openingConstruction, structureLayers)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameOpeningConstructionStructureLayersRelation"/> class using an existing instance.
        /// </summary>
        /// <param name="frameOpeningConstructionStructureLayersRelation">The source relation instance to copy.</param>
        public FrameOpeningConstructionStructureLayersRelation(FrameOpeningConstructionStructureLayersRelation? frameOpeningConstructionStructureLayersRelation)
            : base(frameOpeningConstructionStructureLayersRelation)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameOpeningConstructionStructureLayersRelation"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to populate the properties of the relation.</param>
        public FrameOpeningConstructionStructureLayersRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}